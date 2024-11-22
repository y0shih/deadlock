using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlock
{
    internal static class Offsets
    {       
        internal static IntPtr dwEntityList = 0x219d130;        
        internal static IntPtr ViewMatrix = 0x252bcf0;  
        internal static IntPtr LocalPlayerController = 0x2511bb0;
        internal static IntPtr CCitadelCameraManager = 0x21f2500;

        internal static IntPtr m_boneArray = 0x80;
        //C_CitadelBaseAbility
        //CitadelHeroData_t
        //C_BaseModelEntity
        //C_BasePlayerWeapon
        //CCollisionProperty
        //CCitadelPlayer_ObserverServices
    }
}


