using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum  ObjectTypeEnum : byte
    {
        GAGE = 0,
        SUBCATCTCH =1,
        NODE = 2,
        LINK = 3,
        POLLUT = 4,
        LANDUSE = 5,
        TIMEPATTERN = 6,
        CURVE = 7,
        TSERIES = 8,
        CONTROL = 9,
        TRANSECT = 10,
        AQUIFER = 11,
        UNITHYD = 12,
        SNOWMELT = 13,
        SHAPE = 14,
        LID = 15,
        MAX_OBJ_TYPES
    }
}
