using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Weapon
{
    /*************************************************************************************\
     * If you add a part here, make sure you:
     * - add the name to WeaponPartTypes
     * - Add the constructor call to the new part in Factory_WeaponPart
    \* ***********************************************************************************/
    #region Weiner On A Stick

    public class Weiner_On_A_Stick : IRobotPart, IAttackModifier
    {
        private const string NAME = "Weiner On A Stick";
        private const string DESC = "An ancient weapon that is easy to construct and fun to eat!";
        private const string ACTION = "The Weiner On A Stick strikes it's opponent with an awkward bounce!";
        private const int ATTACK_MOD = 1;

        public Weiner_On_A_Stick ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetAttackModAmount ( ) { return ATTACK_MOD; }
    }
    #endregion

    #region PistonFists

    public class PistonFists : IRobotPart, IAttackModifier
    {
        private const string NAME = "Piston Fists";
        private const string DESC = "School yard rules FTW! Each fist is mounted to a hard-hitting piston for brawling goodness.";
        private const string ACTION = "The Piston Fists pummeles the opponent with a flurry of strikes!";
        private const int ATTACK_MOD = 4;

        public PistonFists ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetAttackModAmount ( ) { return ATTACK_MOD; }
    }
    #endregion

    #region LaserSword

    public class LaserSword : IRobotPart, IAttackModifier
    {
        private const string NAME = "Laser Sword";
        private const string DESC = "An elegant weapon from a more civilized time. It glows with intensity!";
        private const string ACTION = "The Laser Sword slashes the opponent with a flash and a shower of sparks!";
        private const int ATTACK_MOD = 8;

        public LaserSword ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetAttackModAmount ( ) { return ATTACK_MOD; }
    }
    #endregion

}
