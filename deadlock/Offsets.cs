using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlock
{
    internal static class Offsets
    {       
        internal static IntPtr dwEntityList = 0x2092e40;        
        internal static IntPtr ViewMatrix = 0x2276440;  
        internal static IntPtr LocalPlayerController = 0x2265340;
        internal static IntPtr CCitadelCameraManager = 0x20b6620;

        internal static IntPtr m_boneArray = 0x80;
        //C_CitadelBaseAbility
        //CitadelHeroData_t
        //C_BaseModelEntity
        //C_BasePlayerWeapon
        //CCollisionProperty
        //CCitadelPlayer_ObserverServices
    }
}


