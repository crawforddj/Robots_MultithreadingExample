using Robots.RobotParts;
using Robots.RobotParts.Chassis;
using Robots.RobotParts.Mobility;
using Robots.RobotParts.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    #region SamuraiBot

    public class SamuraiBot : IRobot
    {
        const WeaponPartTypes WEAPON = WeaponPartTypes.LaserSword;
        const ChassisPartTypes CHASSIS = ChassisPartTypes.RebarAndSheetMetal;
        const MobilityPartTypes MOBILITYPART = MobilityPartTypes.Legs;

        public SamuraiBot ( int ID ) : base (
                  $"SamuraiBot:{ID}" ,
                  new IRobotPart[ ]
                  {
                      Factory_WeaponPart.Build ( WEAPON ) ,
                      Factory_ChasisPart.Build ( CHASSIS ) ,
                      Factory_MobilityPart.Build ( MOBILITYPART )
                  } )
        { }
    }
    #endregion

    #region TankBot

    public class TankBot : IRobot
    {
        const WeaponPartTypes WEAPON = WeaponPartTypes.PistonFists;
        const ChassisPartTypes CHASSIS = ChassisPartTypes.RebarAndSheetMetal;
        const MobilityPartTypes MOBILITYPART = MobilityPartTypes.Tracks;

        public TankBot ( int ID ) : base (
                  $"TankBot:{ID}" ,
                  new IRobotPart[ ]
                  {
                      Factory_WeaponPart.Build ( WEAPON ) ,
                      Factory_ChasisPart.Build ( CHASSIS ) ,
                      Factory_MobilityPart.Build ( MOBILITYPART )
                  } )
        { }
    }
    #endregion

    #region Weiner Plane

    public class WeinerPlane : IRobot
    {
        const WeaponPartTypes WEAPON = WeaponPartTypes.Weiner_On_A_Stick;
        const ChassisPartTypes CHASSIS = ChassisPartTypes.CardboardBox;
        const MobilityPartTypes MOBILITYPART = MobilityPartTypes.Wings;

        public WeinerPlane ( int ID ) : base (
                  $"WeinerPlane:{ID}" ,
                  new IRobotPart[ ]
                  {
                      Factory_WeaponPart.Build ( WEAPON ) ,
                      Factory_ChasisPart.Build ( CHASSIS ) ,
                      Factory_MobilityPart.Build ( MOBILITYPART )
                  } )
        { }
    }
    #endregion
}
