using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum WeirTypeEnum : byte
    {
        TRANSVERSE_WEIR = 0,                 // transverse weir 
        SIDEFLOW_WEIR = 1,                   // side flow weir 
        VNOTCH_WEIR = 2,                     // V-notch (triangular) weir 
        TRAPEZOIDAL_WEIR =3,                 // trapezoidal weir 
        ROADWAY_WEIR                         // FHWA HDS-5 roadway weir               
    }
}
