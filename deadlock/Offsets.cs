using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlock
{
    internal static class Offsets
    {       
        internal static IntPtr dwEntityList = 0x2092e60;        
        internal static IntPtr ViewMatrix = 0x2276460;  
        internal static IntPtr LocalPlayerController = 0x2265360;
        internal static IntPtr CCitadelCameraManager = 0x20b6640;

        internal static IntPtr m_boneArray = 0x80;
        //C_CitadelBaseAbility
        //CitadelHeroData_t
        //C_BaseModelEntity
        //C_BasePlayerWeapon
        //CCollisionProperty
        //CCitadelPlayer_ObserverServices
    }
}


