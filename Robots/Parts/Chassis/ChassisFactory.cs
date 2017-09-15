using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Parts.Chassis
{
    public static class ChassisFactory
    {
        public static IChassis BuildChassis(ChassisType type )
        {
            switch ( type ) {
                case ChassisType.CardboardBox:
                    return new CardboardBox ( );
                case ChassisType.RebarAndSheetMetal:
                    return new RebarAndSheetMetal ( );
                default:
                    throw new NotSupportedException ( );
            }
        } 
    }

    public enum ChassisType
    {
        CardboardBox,
        RebarAndSheetMetal
    }

    #region CardboardBox

    public class CardboardBox : IRobotPart, IChassis
    {
        private const string NAME = "Cardboard Box";
        private const string DESC = "Athough a flimsy box, Snake seems to make pretty good of these. Maybe there is something to it";
        private const string ACTION = "In a pathetic display, the cardboard armor tears easily to expose the robot's inner components";
        private const int ARMOR_RATING = 5;

        public CardboardBox ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetArmorRating ( ) { return ARMOR_RATING; }
    }
    #endregion

    #region RebarAndSheetMetal

    public class RebarAndSheetMetal : IRobotPart, IChassis
    {
        private const string NAME = "RebarAndSheetMetal";
        private const string DESC = "This may look a little \"Mad Max\", but it should hold up to a bit of punishment";
        private const string ACTION = "The sheet metal tears and the rebar breaks. At least it wasn't cardboard right?";
        private const int ARMOR_RATING = 20;

        public RebarAndSheetMetal ( ) : base ( NAME , DESC , ACTION ) { }

        public int GetArmorRating ( ) { return ARMOR_RATING; }
    }
    #endregion
}
