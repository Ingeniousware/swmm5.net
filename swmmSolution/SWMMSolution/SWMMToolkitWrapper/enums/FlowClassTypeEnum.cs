using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum FlowClassTypeEnum: byte
    {
        DRY = 0,
        UP_DRY = 1,
        DN_DRY = 2,
        SUBCRITICAL = 3,
        SUPCRITICAL = 4,
        UP_CRITICAL = 5,
        DN_CRITICAL = 6,
        MAX_FLOW_CLASSES = 7,
        UP_FULL = 8,
        DN_FULL = 9,
        ALL_FULL
    }
}
