using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts.Mobility
{
    public static class Factory_MobilityPart
    {
        public static IRobotPart Build(MobilityPartTypes type )
        {
            switch ( type ) {
                case MobilityPartTypes.Legs:
                    return new Legs ( );
                case MobilityPartTypes.Tracks:
                    return new Tracks ( );
                case MobilityPartTypes.AllWeatherTires:
                    return new AllWeatherTires ( );
                case MobilityPartTypes.Wings:
                    return new Wings();
                default:
                    throw new NotSupportedException ( );
            }
        }
    }
}
