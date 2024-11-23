using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlock
{
    internal static class Offsets
    {       
        internal static IntPtr dwEntityList = 0x219e110;        
        internal static IntPtr ViewMatrix = 0x252cca0;  
        internal static IntPtr LocalPlayerController = 0x2512b60;
        internal static IntPtr CCitadelCameraManager = 0x21f34d0;

        internal static IntPtr m_boneArray = 0x80;
        //C_CitadelBaseAbility
        //CitadelHeroData_t
        //C_BaseModelEntity
        //C_BasePlayerWeapon
        //CCollisionProperty
        //CCitadelPlayer_ObserverServices
    }
}


