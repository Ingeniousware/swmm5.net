using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetSimulationParam : byte
    {
        /// <summary>
        /// Routing time step (sec)
        /// </summary>
        RouteStep = 0,
        /// <summary>
        /// Minimum variable time step (sec)
        /// </summary>
        MinRouteStep = 1,
        /// <summary>
        /// Time step for lengthening (sec)
        /// </summary>
        LengtheningStep = 2,
        /// <summary>
        /// Antecedent dry days
        /// </summary>
        StartDryDays = 3,
        /// <summary>
        /// Courant time step factor
        /// </summary>
        CourantFactor = 4,
        /// <summary>
        /// Minimum nodal surface area
        /// </summary>
        MinSurfArea = 5,
        /// <summary>
        /// Minimum conduit slope
        /// </summary>
        MinSlope = 6,
        /// <summary>
        /// Runoff continuity error
        /// </summary>
        RunoffError = 7,
        /// <summary>
        /// Groundwater continuity error	
        /// </summary>
        GwaterError = 8,
        /// <summary>
        /// Flow routing error
        /// </summary>
        FlowError = 9,
        /// <summary>
        /// Quality routing error
        /// </summary>
        QualError = 10,
        /// <summary>
        /// DW routing head tolerance (ft)
        /// </summary>
        HeadTol = 11,
        /// <summary>
        /// Tolerance for steady system flow
        /// </summary>
        SysFlowTol = 12,
        /// <summary>
        /// Tolerance for steady nodal inflow
        /// </summary>
        LatFlowTol
    }
}
