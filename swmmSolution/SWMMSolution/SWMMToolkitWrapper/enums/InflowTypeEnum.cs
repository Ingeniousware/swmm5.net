using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum InflowTypeEnum : byte
    {
        EXTERNAL_INFLOW = 0,
        DRY_WEATHER_INFLOW = 1,
        WET_WEATHER_INFLOW = 2,
        GROUNDWATER_INFLOW = 3,
        RDII_INFLOW = 4,
        FLOW_INFLOW = 5,
        CONCEN_INFLOW = 6,
        MASS_INFLOW
    }
}
