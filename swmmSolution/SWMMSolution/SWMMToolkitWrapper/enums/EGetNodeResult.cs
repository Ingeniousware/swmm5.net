using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetNodeResult : byte
    {
        /// <summary>
        /// Total Inflow
        /// </summary>
        inflow = 0,
        /// <summary>
        /// Total Outflow
        /// </summary>
        outflow = 1,
        /// <summary>
        /// Losses (evap + exfiltration loss)
        /// </summary>
        losses = 2,
        /// <summary>
        /// Current Volume
        /// </summary>
        newVolume = 3,
        /// <summary>
        /// overflow
        /// </summary>
        overflow = 4,
        /// <summary>
        /// Current water depth
        /// </summary>
        newDepth = 5,
        /// <summary>
        /// Current water head
        /// </summary>
        newDepthplusinverterElev = 6,
        /// <summary>
        /// Current Lateral Inflow
        /// </summary>
        newLatFlow
    }
}
