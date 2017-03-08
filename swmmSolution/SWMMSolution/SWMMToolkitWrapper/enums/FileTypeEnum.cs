using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum FileTypeEnum : byte
    {
        RAINFALL_FILE = 0,
        RUNOFF_FILE = 1,
        HOTSTART_FILE = 2,
        RDII_FILE = 3,
        INFLOWS_FILE = 4,
        OUTFLOWS_FILE
    }
}
