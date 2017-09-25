using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.RobotParts.Mobility;
using Robots.RobotParts.Chassis;
using Robots.RobotParts.Weapon;
using Robots.RobotParts;

namespace Robots
{
    public abstract class IRobot
    {
        private const int BASE_ATTACK = 1;
        private const int BASE_ARMOR = 1;
        private const int BASE_MOBILTY = 4;

        public string Designator { get; private set; }
        // TODO Make Armor Threadsafe
        public int Armor { get; private set; }
        public int Attack { get; private set; }
        public int Mobility { get; private set; }
        public IRobotPart[] Parts { get; private set; }
        public bool Functional { get; private set; }

        public IRobot(string designator, IRobotPart[] parts )
        {
            this.Armor = BASE_ARMOR;
            this.Attack = BASE_ATTACK;
            this.Mobility = BASE_MOBILTY;

            this.Designator = designator;
            foreach ( IRobotPart part in parts ) {
                ApplyPartModifiers ( part );
            }

            this.Functional = true;
        }

        public void ApplyPartModifiers( IRobotPart part)
        {            
            if ( part is IArmorModifier armorMod )
                Armor += armorMod.GetArmorModAmount ( );
            if ( part is IAttackModifier attackMod )
                Attack += attackMod.GetAttackModAmount ( );
            if ( part is IMobilityModifier mobilityMod )
                Mobility += mobilityMod.GetMobilityModAmount ( );
        }

        public override string ToString ( )
        {
            string output =
                $"=== ROBOT {Designator} ===\n" +
                $"ATTACK : {Attack}\n" +
                $"ARMOR  : {Armor}\n" +
                $"MOBILTY: Moves every {Mobility} milliseconds\n" +
                $"---------------------------\n" +
                $"PARTS:\n";

            foreach ( IRobotPart part in Parts ) 
                output += $" - {part}\n";
            
            return output + "\n\n";
        }
    }
}
