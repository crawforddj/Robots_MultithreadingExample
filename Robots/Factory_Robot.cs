using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.RobotParts.Chassis;
using Robots.RobotParts.Mobility;
using Robots.RobotParts.Weapon;
using Robots.RobotParts;

namespace Robots
{
    public static class Factory_Robot
    {
        private static int ID = 0;

        public static IRobot Build ( RobotTypes type )
        {
            switch ( type ) {
                case RobotTypes.SamuraiBot:
                    return new SamuraiBot ( ID );
                case RobotTypes.TankBot:
                    return new TankBot ( ID );
                case RobotTypes.WeinerPlane:
                    return new WeinerPlane ( ID );
                default:
                    throw new NotSupportedException ( );
            }
        }
    }

}
