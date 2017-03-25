using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum EGetLinkResult : byte
    {
        /// <summary>
        /// Current Flow
        /// </summary>
        newFlow = 0,
        /// <summary>
        /// Current Depth
        /// </summary>
        newDepth = 1,
        /// <summary>
        /// Current Volume
        /// </summary>
        newVolume = 2,
        /// <summary>
        /// Upstream Surface Area
        /// </summary>
        surfArea1 = 3,
        /// <summary>
        /// Downstream Surface Area
        /// </summary>
        surfArea2 = 4,
        /// <summary>
        /// Current Setting
        /// </summary>
        setting = 5,
        /// <summary>
        /// Target Setting
        /// </summary>
        targetSetting = 6,
        /// <summary>
        /// Froude number
        /// </summary>
        froude
    }
}
