using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Weapon
{
    public static class Factory_WeaponPart
    {
        public static IRobotPart Build(WeaponPartTypes type )
        {
            switch ( type ) {
                case WeaponPartTypes.Weiner_On_A_Stick:
                    return new Weiner_On_A_Stick ( );
                case WeaponPartTypes.PistonFists:
                    return new PistonFists ( );
                case WeaponPartTypes.LaserSword:
                    return new LaserSword ( );
                default:
                    throw new NotSupportedException ( );
            }
        }
    }
}
