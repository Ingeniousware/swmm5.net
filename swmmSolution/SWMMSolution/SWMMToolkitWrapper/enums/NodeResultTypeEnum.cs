using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum NodeResultTypeEnum : byte
    {
        NODE_DEPTH = 0,
        NODE_HEAD = 1,
        NODE_VOLUME = 2,
        NODE_LATFLOW = 3,
        NODE_INFLOW = 4,
        NODE_OVERFLOW = 5,
        NODE_QUAL
    }
}
