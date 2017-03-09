using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum OutFallTypeEnum : byte
    {
        FREE_OUTFALL = 0,
        NORMAL_OUTFALL = 1,
        FIXED_OUTFALL = 2,
        TIDAL_OUTFALL = 3,
        TIMESERIES_OUTFALL
    }
}
