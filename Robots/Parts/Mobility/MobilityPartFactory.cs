using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Parts.Mobility
{
    public static class MobilityPartFactory
    {
        public static IMobilityPart BuildMobilityPart(MobilityPartType type )
        {
            switch ( type ) {
                case MobilityPartType.Legs:
                    return new Legs ( );
                case MobilityPartType.Tracks:
                    return new Tracks ( );
                case MobilityPartType.AllWeatherTires:
                    return new AllWeatherTires ( );
                case MobilityPartType.Wings:
                    return new Wings();
                default:
                    throw new NotSupportedException ( );
            }
        }
    }

    public enum MobilityPartType : int
    {
        Legs,
        Tracks,
        AllWeatherTires,
        Wings
    }

    #region Legs

    public class Legs : IRobotPart, IMobilityPart
    {
        private const string NAME = "Legs";
        private const string DESC = "These scrawny chicken legs should work, just don't expect to move very quickly";
        private const string ACTION = "With shifty and uncertain footsteps, the robot has finally made noticable progress";
        private const int MOBILITY = 4000;

        public Legs ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetMobility ( ) { return MOBILITY; }
    }
    #endregion

    #region Tracks

    public class Tracks : IRobotPart, IMobilityPart
    {
        private const string NAME = "Tracks";
        private const string DESC = "These bad boys make anything look like a tank! Still pretty slow though...";
        private const string ACTION = "The robot arrives all awesome-looking on it's creaky squeaky tracks!";
        private const int MOBILITY = 3000;

        public Tracks ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetMobility ( ) { return MOBILITY; }
    }
    #endregion

    #region AllWeatherTires

    public class AllWeatherTires : IRobotPart, IMobilityPart
    {
        private const string NAME = "All-Weather Tires";
        private const string DESC = "Built for speed, but with a sensible consideration for fuel economy and traction in the rain. These tires are a popular choice among minivan enthusiasts!";
        private const string ACTION = "Robot arrives with a screeching halt!";
        private const int MOBILITY = 1500;

        public AllWeatherTires ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetMobility ( ) { return MOBILITY; }
    }
    #endregion

    #region Wings

    public class Wings : IRobotPart, IMobilityPart
    {
        private const string NAME = "Wings";
        private const string DESC = "This VTOL system comes with a MP3 player preloaded with Kenny Loggins \"Danger Zone\" and a pair of aviator glasses. How cool is that!";
        private const string ACTION = "The robot flies overhead as a sonic boom resonates across the battlefield!";
        private const int MOBILITY = 250;

        public Wings ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetMobility ( ) { return MOBILITY; }
    }
    #endregion
}
