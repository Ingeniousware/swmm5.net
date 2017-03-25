using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetSubCatchResult : byte
    {
        /// <summary>
        ///Current Rainfall
        /// </summary>
        rainfall = 0,
        /// <summary>
        /// Current Evaporation Loss
        /// </summary>
        evapLoss = 1,
        /// <summary>
        ///  Current Infiltration Loss
        /// </summary>
        infilLoss = 2,
        /// <summary>
        ///  Subcatchment Runon
        /// </summary>
        runon = 3,
        /// <summary>
        /// Current Runoff
        /// </summary>
        newRunoff = 4,
        /// <summary>
        /// Current Snow Depth
        /// </summary>
        newSnowDepth = 5
    }
}
