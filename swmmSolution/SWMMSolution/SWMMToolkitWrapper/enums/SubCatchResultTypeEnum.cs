using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum SubCatchResultTypeEnum : byte
    {
        SUBCATCH_RAINFALL = 0,
        SUBCATCH_SNOWDEPTH = 1,
        SUBCATCH_EVAP = 2,
        SUBCATCH_INFIL = 3,
        SUBCATCH_RUNOFF = 4,
        SUBCATCH_GW_FLOW = 5,
        SUBCATCH_GW_ELEV = 6,
        SUBCATCH_SOIL_MOIST = 7,
        SUBCATCH_WASHOFF
    }
}
