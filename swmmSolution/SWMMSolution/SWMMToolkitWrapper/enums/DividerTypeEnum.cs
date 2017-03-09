using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum DividerTypeEnum : byte
    {
        CUTOFF_DIVIDER = 0,      // diverted flow is excess of cutoff flow
        TABULAR_DIVIDER = 1,     // table of diverted flow v. inflow
        WEIR_DIVIDER = 2,        // diverted flow proportional to excess flow
        OVERFLOW_DIVIDER         // diverted flow is flow > full conduit flow
    }
}
