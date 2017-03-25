using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetAndSetNodeParam: byte
    {
        /// <summary>
        /// invertElev
        /// </summary>
        invertElev = 0,
        /// <summary>
        /// fullDepth
        /// </summary>
        fullDepth = 1,
        /// <summary>
        /// surDepth
        /// </summary>
        surDepth = 2,
        /// <summary>
        /// pondedArea
        /// </summary>
        pondedArea = 3,
        /// <summary>
        /// initDepth
        /// </summary>
        initDepth = 4
    }
}
