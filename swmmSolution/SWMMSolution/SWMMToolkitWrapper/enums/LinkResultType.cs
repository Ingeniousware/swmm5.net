using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum LinkResultType : byte
    {
        LINK_FLOW = 0,
        LINK_DEPTH = 1,
        LINK_VELOCITY = 2,
        LINK_VOLUME = 3,
        LINK_CAPACITY = 4,
        LINK_QUAL
    }
}
