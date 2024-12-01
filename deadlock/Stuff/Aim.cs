using System;
using System.Numerics;
using System.Runtime.InteropServices;
using static offsetDump.ClientDll;
using deadlock.external;
using deadlock.external.Structs;
using deadlock;
using System.Diagnostics;
class AimAssit
{
    // Windows API for mouse control
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

    const uint MOUSEEVENTF_MOVE = 0x0001;

    // Config
    private const float AimAssistThreshold = 10f; // Adjust as needed
    private const float SmoothingFactor = 0.5f;   // Adjust for smoother aiming
    private const int FOVRadius = 70;

    // offests

    private static long LocalPlayerController = Offsets.LocalPlayerController;    
    private static long ViewMatrixAddress = Offsets.ViewMatrix;    
    private static long EntityList = Offsets.dwEntityList;            
    private static long CameraManager = Offsets.CCitadelCameraManager;         

    // Process memory manager
    private static long CameraAddress = Offsets.CCitadelCameraManager + 0x28;

    static async Task Main(string[] args)
    {
        Initialize();
        Console.WriteLine("Aim Assist Initialized...");

        while (true)
        {
            if (GetAsyncKeyState(0x45) != 0) // E key pressed
            {
                AimAtClosestEnemy();
            }
            await Task.Delay(16); // 
        }
    }

    private static bool Initialize()
    {
        return Memory.Initialize();
    }

    private static void AimAtClosestEnemy()
    {
        var localPosition = GetCameraPosition();
        var viewMatrix = GetViewMatrix();
        var screenCenter = new Vector2(1920 / 2, 1080 / 2);

        float closestDistance = float.MaxValue;
        Vector3? closestEnemy = null;

        for (int i = 1; i <= 16; i++) // 
        {
            var entity = GetEntity(i);
            if (entity == null || entity.Team == GetLocalPlayerTeam() || entity.Health <= 0)
                continue;

            var screenPos = WorldToScreen(entity.Position, viewMatrix, 1920, 1080);
            if (screenPos == null)
                continue;

            var distanceToScreenCenter = Vector2.Distance(screenPos.Value, screenCenter);

            if (distanceToScreenCenter <= FOVRadius && distanceToScreenCenter < closestDistance)
            {
                closestDistance = distanceToScreenCenter;
                closestEnemy = entity.Position;
            }
        }

        if (closestEnemy != null)
        {
            AdjustMouseTowards(closestEnemy.Value, localPosition, viewMatrix, screenCenter);
        }
    }

    private static void AdjustMouseTowards(Vector3 targetPosition, Vector3 cameraPosition, float[,] viewMatrix, Vector2 screenCenter)
    {
        var screenPos = WorldToScreen(targetPosition, viewMatrix, 1920, 1080);
        if (screenPos != null)
        {
            var deltaX = (screenPos.Value.X - screenCenter.X) * SmoothingFactor;
            var deltaY = (screenPos.Value.Y - screenCenter.Y) * SmoothingFactor;

            mouse_event(MOUSEEVENTF_MOVE, (uint)deltaX, (uint)deltaY, 0, 0);
        }
    }

    private static Vector3 GetCameraPosition()
    {
        float x = Memory.Read<float>((nint)(CameraAddress + 0x38));
        float y = Memory.Read<float>((nint)(CameraAddress + 0x3C)); 
        float z = Memory.Read<float>((nint)(CameraAddress + 0x40));
        return new Vector3(x, y, z);
    }

    private static float[,] GetViewMatrix()
    {
        float[,] matrix = new float[4, 4];
        var process = Process.GetCurrentProcess();
        var mainModule = process.MainModule ?? throw new InvalidOperationException("Could not access process main module");
        
        for (int i = 0; i < 16; i++)
        {
            matrix[i / 4, i % 4] = Memory.Read<float>(mainModule.BaseAddress + Offsets.ViewMatrix + i * 4);
        }
        return matrix;
    }

    private static Vector2? WorldToScreen(Vector3 worldPos, float[,] viewMatrix, int screenWidth, int screenHeight)
    {
        var clipCoords = new Vector4
        {
            X = worldPos.X * viewMatrix[0, 0] + worldPos.Y * viewMatrix[1, 0] + worldPos.Z * viewMatrix[2, 0] + viewMatrix[3, 0],
            Y = worldPos.X * viewMatrix[0, 1] + worldPos.Y * viewMatrix[1, 1] + worldPos.Z * viewMatrix[2, 1] + viewMatrix[3, 1],
            Z = worldPos.X * viewMatrix[0, 2] + worldPos.Y * viewMatrix[1, 2] + worldPos.Z * viewMatrix[2, 2] + viewMatrix[3, 2],
            W = worldPos.X * viewMatrix[0, 3] + worldPos.Y * viewMatrix[1, 3] + worldPos.Z * viewMatrix[2, 3] + viewMatrix[3, 3]
        };

        if (clipCoords.W < 0.1f)
            return null;

        var ndc = new Vector2
        {
            X = clipCoords.X / clipCoords.W,
            Y = clipCoords.Y / clipCoords.W
        };

        var screen = new Vector2
        {
            X = (screenWidth / 2f) * (ndc.X + 1),
            Y = (screenHeight / 2f) * (1 - ndc.Y)
        };

        return screen;
    }

    private static Entity? GetEntity(int index)
    {
        long entityBase = Memory.Read<long>((nint)(EntityList + (8 * index)));
        if (entityBase == 0)
            return null;

        long gameSceneNode = Memory.Read<long>((nint)(entityBase + C_BaseEntity.m_pGameSceneNode));
        long modelState = Memory.Read<long>((nint)(gameSceneNode + CSkeletonInstance.m_modelState));
        long boneArray = Memory.Read<long>((nint)(modelState + 0x80)); // m_boneArray offset

        var skeleton = new Skeleton(new Player((int)entityBase));
        skeleton.Update((IntPtr)gameSceneNode);
        
        var position = skeleton.HeadPos;
        int health = Memory.Read<int>((nint)(entityBase + C_BaseEntity.m_iHealth));
        int team = Memory.Read<int>((nint)(entityBase + C_BaseEntity.m_iTeamNum));

        return new Entity { Position = position, Health = health, Team = team };
    }

    private static int GetHeadBoneIndex(int heroId)
    {
        return heroId switch
        {
            (int)HeroIds.Abrams => 7,
            (int)HeroIds.Bebop => 6,
            (int)HeroIds.Dynamo => 13,
            (int)HeroIds.GreyTalon => 17,
            (int)HeroIds.Haze => 7,
            (int)HeroIds.Infernus => 30,
            (int)HeroIds.Ivy => 13,
            (int)HeroIds.Kelvin => 12,
            (int)HeroIds.LadyGeist => 11,
            (int)HeroIds.Lash => 12,
            (int)HeroIds.McGinnis => 7,
            (int)HeroIds.MoAndKrill => 25,
            (int)HeroIds.Paradox => 8,
            (int)HeroIds.Pocket => 13,
            (int)HeroIds.Seven => 14,
            (int)HeroIds.Shiv => 13,
            (int)HeroIds.Vindicta => 7,
            (int)HeroIds.Viscous => 7,
            (int)HeroIds.Warden => 11,
            (int)HeroIds.Wraith => 7,
            (int)HeroIds.Yamato => 35,
            (int)HeroIds.Mirage => 8,
            // head bone index
        };
    }

    private static int GetLocalPlayerTeam()
    {
        return Memory.Read<int>((nint)(Memory.ClientPtr + Offsets.LocalPlayerController + C_BaseEntity.m_iTeamNum));
    }

    private class Entity
    {
        public Vector3 Position { get; set; }
        public int Health { get; set; }
        public int Team { get; set; }
    }

    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int vKey);
}
