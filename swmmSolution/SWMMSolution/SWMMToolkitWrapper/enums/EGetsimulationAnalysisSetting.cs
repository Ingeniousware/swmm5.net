using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetsimulationAnalysisSetting: byte
    {
        /// <summary>
        /// No ponding at nodes (True or False)
        /// </summary>
        AllowPonding = 0,
        /// <summary>
        /// Do flow routing in steady state periods  (True or False)
        /// </summary>
        SkipSteadyState = 1,
        /// <summary>
        /// Analyze rainfall/runoff  (True or False)
        /// </summary>
        IgnoreRainfall = 2,
        /// <summary>
        /// Analyze RDII (True or False)
        /// </summary>
        IgnoreRDII = 3,
        /// <summary>
        /// Analyze snowmelt (True or False)
        /// </summary>
        IgnoreSnowmelt = 4,
        /// <summary>
        /// Analyze groundwater (True or False)
        /// </summary>
        IgnoreGwater = 5,
        /// <summary>
        /// Analyze flow routing (True or False)
        /// </summary>
        IgnoreRouting = 6,
        /// <summary>
        /// Analyze water quality (True or False)
        /// </summary>
        IgnoreQuality = 7
    }
}
