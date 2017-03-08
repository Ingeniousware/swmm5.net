using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum XSectionTypeEnum : byte
    {
        DUMMY = 0,
        CIRCULAR = 1,
        FILLED_CIRCULAR = 2,
        RECT_CLOSED = 3,
        RECT_OPEN = 4,
        TRAPEZOIDAL = 5,
        TRIANGULAR = 6,
        PARABOLIC = 7,
        POWERFUNC = 8,
        RECT_TRIANG = 9,
        RECT_ROUND = 10,
        MOD_BASKET = 11,
        HORIZ_ELLIPSE = 12,
        VERT_ELLIPSE = 13,
        ARCH = 14,
        EGGSHAPED = 15,
        HORSESHOE = 16,
        GOTHIC = 17,
        CATENARY = 18,
        SEMIELLIPTICAL = 19,
        BASKETHANDLE = 20,
        SEMICIRCULAR = 21,
        IRREGULAR = 22,
        CUSTOM = 23,
        FORCE_MAIN
    }
}
