using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum BuildUpTypeEnum : byte
    {
        NO_BUILDUP = 0,
        POWER_BUILDUP = 1,
        EXPON_BUILDUP = 2,
        SATUR_BUILDUP = 3,
        EXTERNAL_BUILDUP
    }
}
