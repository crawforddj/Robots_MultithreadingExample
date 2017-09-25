using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Chassis
{
    public static class Factory_ChasisPart
    {
        public static IRobotPart Build ( ChassisPartTypes type )
        {
            switch ( type ) {

                case ChassisPartTypes.CardboardBox:
                    return new CardboardBox ( );

                case ChassisPartTypes.RebarAndSheetMetal:
                    return new RebarAndSheetMetal ( );

                default:
                    throw new NotSupportedException ( );
            }
        }
    }
}
