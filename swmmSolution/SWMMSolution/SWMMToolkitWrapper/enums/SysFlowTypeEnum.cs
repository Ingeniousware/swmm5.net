using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
   public enum SysFlowTypeEnum : byte
    {
        SYS_TEMPERATURE = 0,
        SYS_RAINFALL = 1,
        SYS_SNOWDEPTH = 2,
        SYS_INFIL = 3,
        SYS_RUNOFF = 4,
        SYS_DWFLOW = 5,
        SYS_GWFLOW = 6,
        SYS_IIFLOW = 7,
        SYS_EXFLOW = 8,
        SYS_INFLOW = 9,
        SYS_FLOODING = 10,
        SYS_OUTFLOW = 11,
        SYS_STORAGE = 12,
        SYS_EVAP = 13,
        SYS_PET
    }
}
