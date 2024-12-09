using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using deadlock;
using deadlock.external;
using deadlock.external.Structs;

namespace AimModule
{
    public static class AimUpdater
    {
        public static Vector3 DisplayPos = new Vector3(0, 0, 0);
        private static int? PlayerIndex = null;
        private static int? EntityArrayIndex = null;

        // Update the AimUpdater to use the new camera and view matrix handling
        public static void Update(AimSettings settings, UdpClient socket, External game)
        {
            DisplayPos = new Vector3(0, 0, 0);

            if 
                return;

            UpdateTargets(settings, game);

            if (PlayerIndex.HasValue)
            {
                var target = game.GetPlayerByIndex(PlayerIndex.Value);
                var targetPos = target.Skeleton.TargetBonePos;
                var targetPosScreen = targetPos;
                // Use the updated method for transforming target positions
                game.MatrixViewProjectionViewport.Transform(ref targetPosScreen);
                DisplayPos = new Vector3(targetPosScreen.X, targetPosScreen.Y, 0f);

                AimTo(targetPos, settings.AnglePerPixel, game, settings.Players, socket);
            }
        }

        private static void UpdateTargets()
        {

        }

        private static void FindPlayer(Program external, Player localPlayer)
        {
            if (!settings.Targeting)
                PlayerIndex = null;

            float minDistance = float.MaxValue;
            var screenCenter = external.Screen.Center();

            foreach (var player in external.Players)
            {
                if (player.Pawn.Team != external.GetLocalPlayer().Pawn.Team && player.IsAlive())
                {
                    var targetPos = player.Skeleton.TargetBonePos;

                    if (external.MatrixViewProjection.Transform(ref targetPos) &&
                        InFov(targetPos, screenCenter, settings.Fov))
                    {
                        var curDistance = Vector3.Distance(targetPos, Vector3FromPos2(screenCenter));

                        if (curDistance < minDistance &&
                            Vector3.Distance(player.GameSceneNode.Position, localPlayer.GameSceneNode.Position) < settings.Range)
                        {
                            minDistance = curDistance;
                            PlayerIndex = player.Index;
                        }
                    }
                }
            }
        }

        private static void FindEntity(Memory game, Player localPlayer, AimProperties settings, AimSettings globalSettings)
        {
            if (!settings.Targeting)
                EntityArrayIndex = null;

            float minDistance = float.MaxValue;
            int maxPriority = 0;
            var screenCenter = game.Screen.Center();

            for (int i = 0; i < game.Entities.Length; i++)
            {
                var entity = game.Entities[i];
                if (entity.ContinueAlive() || entity.CheckCreep(localPlayer) || entity.GameSceneNode.Dormant)
                    continue;

                int priority = entity.Class.GetPriority(globalSettings.Priority);
                if (priority >= maxPriority)
                {
                    if (priority > maxPriority)
                        minDistance = float.MaxValue;

                    var headPos = entity.GameSceneNode.Position;
                    if (entity.Class == EntityType.Creep)
                        headPos.Z += 35f;

                    if (!entity.GameSceneNode.Dormant &&
                        game.MatrixViewProjection.Transform(ref headPos) &&
                        InFov(headPos, screenCenter, settings.Fov))
                    {
                        float curDistance = Vector3.Distance(headPos, Vector3FromPos2(screenCenter));

                        if (curDistance < minDistance &&
                            Vector3.Distance(entity.GameSceneNode.Position, localPlayer.GameSceneNode.Position) < settings.Range)
                        {
                            maxPriority = priority;
                            minDistance = curDistance;
                            EntityArrayIndex = i;
                        }
                    }
                }
            }
        }

        // private static Vector3 CalcVelocity(Vector3 worldPos, Vector3 velocity)
        // {
        //     if (!settings.VelocityPrediction)
        //         return worldPos;

        //     return new Vector3(
        //         worldPos.X + velocity.X / settings.VelocityDiv,
        //         worldPos.Y + velocity.Y / settings.VelocityDiv,
        //         worldPos.Z + velocity.Z / settings.VelocityDiv
        //     );
        // }

        // private static void AimTo(Vector3 targetWorld, float anglePerPixel,UdpClient socket)
        // {
        //     var aimDirection = GetAimDirection(Memory.ClientPtr);
        //     var desiredDirection = Vector3.Normalize(targetWorld - CalcVelocity(Offsets.ViewMatrix, Offsets.LocalPlayerController).Pawn.Velocity));

        //     var aimAngles = new Vector3
        //     {
        //         X = AngleToSigned(desiredDirection, aimDirection, new Vector3(0, 0, 1)),
        //         Y = AngleToSigned(desiredDirection, aimDirection, Vector3.Normalize(Vector3.Cross(desiredDirection, new Vector3(0, 0, 1)))),
        //         Z = 0
        //     };

        //     aimAngles *= 1f / Smooth;

        //     var aimPixels = new Vector2(
        //         MathF.Round((aimAngles.X / anglePerPixel) * 100f) / 100f,
        //         MathF.Round((aimAngles.Y / anglePerPixel) * 100f) / 100f
        //     );

        //     if (aimPixels.X != 0f || aimPixels.Y != 0f)
        //     {
        //         Connection.SendMove(socket, (int)aimPixels.X, (int)aimPixels.Y);
        //     }
        // }

        private static bool InFov(Vector3 point, Vector2 center, float radius)
        {
            return Vector3.Distance(point, Vector3FromPos2(center)) <= radius;
        }

        private static Vector3 Vector3FromPos2(Vector2 pos)
        {
            return new Vector3(pos.X, pos.Y, 0);
        }

        private static Vector3 GetAimDirection(IntPtr clientPtr, Vector3 punch)
        {
            var camera = .Default();
            camera.Update(clientPtr);
            camera.ViewAngles.X += punch.X;
            camera.ViewAngles.Y += punch.Y;
            return VectorFromEulerAngles(camera.ViewAngles.X, camera.ViewAngles.Y);
        }

        private static Vector3 VectorFromEulerAngles(float phi, float theta)
        {
            return Vector3.Normalize(new Vector3(
                MathF.Cos(phi) * MathF.Cos(theta),
                MathF.Cos(phi) * MathF.Sin(theta),
                MathF.Sin(phi)
            ));
        }

        private static float AngleToSigned(Vector3 vec1, Vector3 vec2, Vector3 about)
        {
            vec2.Z *= -1;

            var plane = Plane.FromPoint(about, Vector3.Zero);
            var vectorOnPlane = Vector3.Normalize(plane.ProjectVector(vec1));
            var otherOnPlane = Vector3.Normalize(plane.ProjectVector(vec2));

            var sign = Vector3.Dot(Vector3.Normalize(Vector3.Cross(vectorOnPlane, otherOnPlane)), plane.Normal);
            return AngleBetweenUnitVectors(vectorOnPlane, otherOnPlane) * sign;
        }

        private static float AngleBetweenUnitVectors(Vector3 left, Vector3 right)
        {
            return MathF.Acos(Clamp(Vector3.Dot(left, right), -1f, 1f));
        }

        private static float Clamp(float value, float min, float max)
        {
            return MathF.Max(min, MathF.Min(max, value));
        }
    }
}
