using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlock
{
    internal static class Offsets
    {
        internal static IntPtr dwEntityList = 0x1fc4440;
        internal static IntPtr ViewMatrix = 0x218cfd0;
        internal static IntPtr LocalPlayerController = 0x217b0d8;
        internal static IntPtr CCitadelCameraManager = 0x1fe6e40;

        internal static IntPtr m_boneArray = 0x80;
        //C_CitadelBaseAbility
        //CitadelHeroData_t
        //C_BaseModelEntity
        //C_BasePlayerWeapon
        //CCollisionProperty
        //CCitadelPlayer_ObserverServices
    }
}


