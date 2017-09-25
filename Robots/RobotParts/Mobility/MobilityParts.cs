using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Mobility
{
    /*************************************************************************************\
     * If you add a part here, make sure you:
     * - add the name to MobilityPartTypes
     * - Add the constructor call to the new part in Factory_MobilityPart
    \* ***********************************************************************************/

    #region Legs

    public class Legs : IRobotPart, IMobilityModifier
        {
            private const string NAME = "Legs";
            private const string DESC = "These scrawny chicken legs should work, just don't expect to move very quickly";
            private const string ACTION = "With shifty and uncertain footsteps, the robot has finally made noticable progress";
            private const int MOBILITY = 4000;

            public Legs ( ) : base ( NAME , DESC , ACTION ) { }

            public int GetMobilityModAmount ( ) { return MOBILITY; }
        }
        #endregion

        #region Tracks

        public class Tracks : IRobotPart, IMobilityModifier
        {
            private const string NAME = "Tracks";
            private const string DESC = "These bad boys make anything look like a tank! Still pretty slow though...";
            private const string ACTION = "The robot arrives all awesome-looking on it's creaky squeaky tracks!";
            private const int MOBILITY = 3000;

            public Tracks ( ) : base ( NAME , DESC , ACTION ) { }

            public int GetMobilityModAmount ( ) { return MOBILITY; }
        }
        #endregion

        #region AllWeatherTires

        public class AllWeatherTires : IRobotPart, IMobilityModifier
        {
            private const string NAME = "All-Weather Tires";
            private const string DESC = "Built for speed, but with a sensible consideration for fuel economy and traction in the rain. These tires are a popular choice among minivan enthusiasts!";
            private const string ACTION = "Robot arrives with a screeching halt!";
            private const int MOBILITY = 1500;

            public AllWeatherTires ( ) : base ( NAME , DESC , ACTION ) { }

            public int GetMobilityModAmount ( ) { return MOBILITY; }
        }
        #endregion

        #region Wings

        public class Wings : IRobotPart, IMobilityModifier
        {
            private const string NAME = "Wings";
            private const string DESC = "This VTOL system comes with a MP3 player preloaded with Kenny Loggins \"Danger Zone\" and a pair of aviator glasses. How cool is that!";
            private const string ACTION = "The robot flies overhead as a sonic boom resonates across the battlefield!";
            private const int MOBILITY = 250;

            public Wings ( ) : base ( NAME , DESC , ACTION ) { }

            public int GetMobilityModAmount ( ) { return MOBILITY; }
        }
        #endregion
}
