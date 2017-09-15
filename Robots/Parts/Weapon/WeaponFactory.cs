using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Parts.Weapon
{
    public static class WeaponFactory
    {
        public static IWeapon BuildWeapon(WeaponType type )
        {
            switch ( type ) {
                case WeaponType.Weiner_On_A_Stick:
                    return new Weiner_On_A_Stick ( );
                case WeaponType.PistonFists:
                    return new PistonFists ( );
                case WeaponType.LaserSword:
                    return new LaserSword ( );
                default:
                    throw new NotSupportedException ( );
            }
        }
    }

    public enum WeaponType
    {
        Weiner_On_A_Stick,
        PistonFists,
        LaserSword
    }

    #region Weiner On A Stick

    public class Weiner_On_A_Stick : IRobotPart, IWeapon
    {
        private const string NAME = "Weiner On A Stick";
        private const string DESC = "An ancient weapon that is easy to construct and fun to eat!";
        private const string ACTION = "The Weiner On A Stick strikes it's opponent with an awkward bounce!";
        private const int DAMAGE = 1;

        public Weiner_On_A_Stick ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetDamage ( ) { return DAMAGE; }
    }
    #endregion

    #region PistonFists

    public class PistonFists : IRobotPart, IWeapon
    {
        private const string NAME = "Piston Fists";
        private const string DESC = "School yard rules FTW! Each fist is mounted to a hard-hitting piston for brawling goodness.";
        private const string ACTION = "The Piston Fists pummeles the opponent with a flurry of strikes!";
        private const int DAMAGE = 4;

        public PistonFists ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetDamage ( ) { return DAMAGE; }
    }
    #endregion

    #region LaserSword

    public class LaserSword : IRobotPart, IWeapon
    {
        private const string NAME = "Laser Sword";
        private const string DESC = "An elegant weapon from a more civilized time. It glows with intensity!";
        private const string ACTION = "The Laser Sword slashes the opponent with a flash and a shower of sparks!";
        private const int DAMAGE = 8;

        public LaserSword ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetDamage ( ) { return DAMAGE; }
    }
    #endregion
}
