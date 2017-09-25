
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Chassis
{
    /*************************************************************************************\
     * If you add a part here, make sure you:
     * - add the name to ChasisTypes
     * - Add the constructor call to the new part in Factory_ChasisPart
    \* ***********************************************************************************/

    public class CardboardBox : IRobotPart, IArmorModifier, IMobilityModifier
    {
        private const string NAME = "Cardboard Box";
        private const string DESC = "Athough a flimsy box, Snake seems to make pretty good of these. Maybe there is something to it";
        private const string ACTION = "In a pathetic display, the cardboard armor tears easily to expose the robot's inner components";
        private const int ARMOR_MOD = 5;
        private const int MOBILITY_MOD = -4500;

        public CardboardBox ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetArmorModAmount ( ) { return ARMOR_MOD; }

        public int GetMobilityModAmount ( )
        {
            return MOBILITY_MOD;
        }
    }

    public class RebarAndSheetMetal : IRobotPart, IArmorModifier, IMobilityModifier
    {
        private const string NAME = "RebarAndSheetMetal";
        private const string DESC = "This may look a little \"Mad Max\", but it should hold up to a bit of punishment";
        private const string ACTION = "The sheet metal tears and the rebar breaks. At least it wasn't cardboard right?";
        private const int ARMOR_RATING = 20;
        private const int MOBILITY_MODIFIER = 2000;

        public RebarAndSheetMetal ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetArmorModAmount ( ) { return ARMOR_RATING; }

        public int GetMobilityModAmount ( ) { return MOBILITY_MODIFIER; }
    }
}
