using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots;
using Robots.RobotParts.Weapon;
using Robots.RobotParts.Chassis;
using Robots.RobotParts.Mobility;

namespace UnitTest_Robots
{
    [TestClass]
    public class UnitTest_Robots
    {
        [TestMethod]
        public void ConstructAllRobotTypes ( )
        {
            foreach ( RobotTypes type in Enum.GetValues(typeof(RobotTypes)) ) 
                Factory_Robot.Build ( type );
            
        }

        [TestMethod]
        public void ConstructAllWeaponTypes ( )
        {
            foreach ( WeaponPartTypes type in Enum.GetValues ( typeof ( WeaponPartTypes ) ) )
                Factory_WeaponPart.Build ( type );
        }

        [TestMethod]
        public void ConstructAllChassisTypes ( )
        {
            foreach ( ChassisPartTypes type in Enum.GetValues ( typeof ( ChassisPartTypes ) ) )
                Factory_ChasisPart.Build ( type );
        }

        [TestMethod]
        public void ConstructAllMobilityPartTypes ( )
        {
            foreach ( MobilityPartTypes type in Enum.GetValues ( typeof ( MobilityPartTypes ) ) )
                Factory_MobilityPart.Build ( type );
        }
    }
}
