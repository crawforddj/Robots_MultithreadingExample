using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.Parts.Chassis;
using Robots.Parts.Mobility;
using Robots.Parts.Weapon;

namespace Robots
{
    public static class RobotFactory
    {
        private static int ID = 0;

        public static Robot BuildRobot ( RobotType type )
        {
            switch ( type ) {
                case RobotType.SamuraiBot:
                    return new SamuraiBot ( ID );
                case RobotType.TankBot:
                    return new TankBot ( ID );
                case RobotType.WeinerPlane:
                    return new WeinerPlane ( ID );
                default:
                    throw new NotSupportedException ( );
            }
        }
    }
    public enum RobotType
    {
        SamuraiBot,
        TankBot,
        WeinerPlane
    }

    #region SamuraiBot

    public class SamuraiBot : Robot
    {
        const WeaponType WEAPON = WeaponType.LaserSword;
        const ChassisType CHASSIS = ChassisType.RebarAndSheetMetal;
        const MobilityPartType MOBILITYPART = MobilityPartType.Legs;

        public SamuraiBot ( int ID ) : base (
                  $"SamuraiBot:{ID}" ,
                  WeaponFactory.BuildWeapon ( WEAPON ) ,
                  ChassisFactory.BuildChassis ( CHASSIS ) ,
                  MobilityPartFactory.BuildMobilityPart ( MOBILITYPART )
                  )
        { }
    }
    #endregion

    #region TankBot

    public class TankBot : Robot
    {
        const WeaponType WEAPON = WeaponType.PistonFists;
        const ChassisType CHASSIS = ChassisType.RebarAndSheetMetal;
        const MobilityPartType MOBILITYPART = MobilityPartType.Tracks;

        public TankBot ( int ID ) : base (
                  $"TankBot:{ID}" ,
                  WeaponFactory.BuildWeapon ( WEAPON ) ,
                  ChassisFactory.BuildChassis ( CHASSIS ) ,
                  MobilityPartFactory.BuildMobilityPart ( MOBILITYPART )
                  )
        { }
    }
    #endregion

    #region Weiner Plane

    public class WeinerPlane : Robot
    {
        const WeaponType WEAPON = WeaponType.Weiner_On_A_Stick;
        const ChassisType CHASSIS = ChassisType.CardboardBox;
        const MobilityPartType MOBILITYPART = MobilityPartType.Wings;

        public WeinerPlane ( int ID ) : base (
                  $"WeinerPlane:{ID}" ,
                  WeaponFactory.BuildWeapon ( WEAPON ) ,
                  ChassisFactory.BuildChassis ( CHASSIS ) ,
                  MobilityPartFactory.BuildMobilityPart ( MOBILITYPART )
                  )
        { }
    }
    #endregion
}
