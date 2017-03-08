using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EvapTypeEnum : byte
    {
        CONSTANT_EVAP = 0,
        MONTHLY_EVAP = 1,
        TIMESERIES_EVAP = 2,
        TEMPERATURE_EVAP = 3,
        FILE_EVAP = 4,
        RECOVERY = 5,
        DRYONLY
    }
}
