using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.Parts.Mobility;
using Robots.Parts.Chassis;
using Robots.Parts.Weapon;

namespace Robots
{
    public abstract class Robot
    {
        public string Designator { get; private set; }
        public IWeapon Weapon { get; private set; }
        public IChassis Chassis { get; private set; }
        public IMobilityPart MobilityPart { get; private set; }
        public bool Functional { get; private set; }

        public Robot(string designator, IWeapon weapon,IChassis chassis, IMobilityPart mobilityPart )
        {
            this.Designator = designator;
            this.Weapon = weapon;
            this.Chassis = chassis;
            this.MobilityPart = mobilityPart;
            this.Functional = true;
        }

        public override string ToString ( )
        {
            return 
                $"=== ROBOT {Designator} ===\n" +
                $"WEAPON:\n {Weapon}\n" +
                $"CHASSIS:\n {Chassis}\n" +
                $"MOBILITY:\n {MobilityPart}\n";
        }
    }
}
