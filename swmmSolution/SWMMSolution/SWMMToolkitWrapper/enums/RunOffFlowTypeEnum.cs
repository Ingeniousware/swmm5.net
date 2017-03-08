using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum RunOffFlowTypeEnum : byte
    {
        RUNOFF_RAINFALL = 0,
        RUNOFF_EVAP = 1,
        RUNOFF_INFIL = 2,
        RUNOFF_RUNOFF = 3,
        RUNOFF_DRAINS = 4,
        RUNOFF_RUNON
    }
}
