using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum LoadingTypeEnum : byte
    {
        BUILDUP_LOAD = 0,
        DEPOSITION_LOAD = 1,
        SWEEPING_LOAD = 2,
        BMP_REMOVAL_LOAD = 3,
        INFIL_LOAD = 4,
        RUNOFF_LOAD = 5,
        FINAL_LOAD
    }
}
