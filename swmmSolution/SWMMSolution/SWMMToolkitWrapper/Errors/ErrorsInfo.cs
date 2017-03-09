using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper
{
    public class ErrorsInfo
    {
        public Dictionary<int, ErrorCodeMsg> ErrorMsg { get; set; }

        public ErrorsInfo()
        {
            ErrorMsg = new Dictionary<int, ErrorCodeMsg>();

            ErrorMsg.Add(0, new ErrorCodeMsg() {
                SWMMIndex = 0,
                ErrorCode = 0,
                ErrorMesg = ""
            });

            ErrorMsg.Add(101, new ErrorCodeMsg()
            {
                SWMMIndex = 1,
                ErrorCode = 101,
                ErrorMesg = "ERROR 101: memory allocation error"
            });

            ErrorMsg.Add(103, new ErrorCodeMsg()
            {
                SWMMIndex = 2,
                ErrorCode = 103,
                ErrorMesg = "ERROR 103: cannot solve KW equations for Link %s"
            });

            ErrorMsg.Add(105, new ErrorCodeMsg()
            {
                SWMMIndex = 3,
                ErrorCode = 105,
                ErrorMesg = "ERROR 105: cannot open ODE solver"
            });

            ErrorMsg.Add(107, new ErrorCodeMsg()
            {
                SWMMIndex = 4,
                ErrorCode = 107,
                ErrorMesg = "ERROR 107: cannot compute a valid time step"
            });

            ErrorMsg.Add(108, new ErrorCodeMsg()
            {
                SWMMIndex = 5,
                ErrorCode = 108,
                ErrorMesg = "ERROR 108: ambiguous outlet ID name for Subcatchment"
            });

            ErrorMsg.Add(109, new ErrorCodeMsg()
            {
                SWMMIndex = 6,
                ErrorCode = 109,
                ErrorMesg = "ERROR 109: invalid parameter values for Aquifer"
            });

            ErrorMsg.Add(110, new ErrorCodeMsg()
            {
                SWMMIndex = 7,
                ErrorCode = 110,
                ErrorMesg = "ERROR 110: ground elevation is below water table for Subcatchment"
            });

            ErrorMsg.Add(111, new ErrorCodeMsg()
            {
                SWMMIndex = 8,
                ErrorCode = 111,
                ErrorMesg = "ERROR 111: invalid length for Conduit"
            });

            ErrorMsg.Add(112, new ErrorCodeMsg()
            {
                SWMMIndex = 9,
                ErrorCode = 112,
                ErrorMesg = "ERROR 112: elevation drop exceeds length for Conduit"
            });

            ErrorMsg.Add(113, new ErrorCodeMsg()
            {
                SWMMIndex = 10,
                ErrorCode = 113,
                ErrorMesg = "ERROR 113: invalid roughness for Conduit"
            });

            ErrorMsg.Add(114, new ErrorCodeMsg()
            {
                SWMMIndex = 11,
                ErrorCode = 114,
                ErrorMesg = "ERROR 114: invalid number of barrels for Conduit"
            });

            ErrorMsg.Add(115, new ErrorCodeMsg()
            {
                SWMMIndex = 12,
                ErrorCode = 115,
                ErrorMesg = "ERROR 115: adverse slope for Conduit"
            });

            ErrorMsg.Add(117, new ErrorCodeMsg()
            {
                SWMMIndex = 13,
                ErrorCode = 117,
                ErrorMesg = "ERROR 117: no cross section defined for Link"
            });

            ErrorMsg.Add(119, new ErrorCodeMsg()
            {
                SWMMIndex = 14,
                ErrorCode = 119,
                ErrorMesg = "ERROR 119: invalid cross section for Link"
            });

            ErrorMsg.Add(121, new ErrorCodeMsg()
            {
                SWMMIndex = 15,
                ErrorCode = 121,
                ErrorMesg = "ERROR 121: missing or invalid pump curve assigned to Pump"
            });

            ErrorMsg.Add(122, new ErrorCodeMsg()
            {
                SWMMIndex = 16,
                ErrorCode = 122,
                ErrorMesg = "ERROR 122: startup depth not higher than shutoff depth for Pump"
            });

            ErrorMsg.Add(131, new ErrorCodeMsg()
            {
                SWMMIndex = 17,
                ErrorCode = 131,
                ErrorMesg = "ERROR 131: the following links form cyclic loops in the drainage system:"
            });

            ErrorMsg.Add(133, new ErrorCodeMsg()
            {
                SWMMIndex = 18,
                ErrorCode = 133,
                ErrorMesg = "ERROR 133: Node %s has more than one outlet link"
            });

            ErrorMsg.Add(134, new ErrorCodeMsg()
            {
                SWMMIndex = 19,
                ErrorCode = 134,
                ErrorMesg = "ERROR 134: Node %s has illegal DUMMY link connections"
            });

            ErrorMsg.Add(135, new ErrorCodeMsg()
            {
                SWMMIndex = 20,
                ErrorCode = 135,
                ErrorMesg = "ERROR 135: Divider %s does not have two outlet links"
            });

            ErrorMsg.Add(136, new ErrorCodeMsg()
            {
                SWMMIndex = 21,
                ErrorCode = 136,
                ErrorMesg = "ERROR 136: Divider %s has invalid diversion link"
            });

            ErrorMsg.Add(137, new ErrorCodeMsg()
            {
                SWMMIndex = 22,
                ErrorCode = 137,
                ErrorMesg = "ERROR 137: Weir Divider %s has invalid parameters"
            });

            ErrorMsg.Add(138, new ErrorCodeMsg()
            {
                SWMMIndex = 23,
                ErrorCode = 138,
                ErrorMesg = "ERROR 138: Node %s has initial depth greater than maximum depth"
            });

            ErrorMsg.Add(139, new ErrorCodeMsg()
            {
                SWMMIndex = 24,
                ErrorCode = 139,
                ErrorMesg = "ERROR 139: Regulator %s is the outlet of a non-storage node"
            });

            ErrorMsg.Add(141, new ErrorCodeMsg()
            {
                SWMMIndex = 25,
                ErrorCode = 141,
                ErrorMesg = "ERROR 141: Outfall %s has more than 1 inlet link or an outlet link"
            });

            ErrorMsg.Add(143, new ErrorCodeMsg()
            {
                SWMMIndex = 26,
                ErrorCode = 143,
                ErrorMesg = "ERROR 143: Regulator %s has invalid cross-section shape"
            });

            ErrorMsg.Add(145, new ErrorCodeMsg()
            {
                SWMMIndex = 27,
                ErrorCode = 145,
                ErrorMesg = "ERROR 145: Drainage system has no acceptable outlet nodes"
            });

            ErrorMsg.Add(151, new ErrorCodeMsg()
            {
                SWMMIndex = 28,
                ErrorCode = 151,
                ErrorMesg = "ERROR 151: a Unit Hydrograph in set %s has invalid time base"
            });

            ErrorMsg.Add(153, new ErrorCodeMsg()
            {
                SWMMIndex = 29,
                ErrorCode = 153,
                ErrorMesg = "ERROR 153: a Unit Hydrograph in set %s has invalid response ratios"
            });

            ErrorMsg.Add(155, new ErrorCodeMsg()
            {
                SWMMIndex = 30,
                ErrorCode = 155,
                ErrorMesg = "ERROR 155: invalid sewer area for RDII at node"
            });

            ErrorMsg.Add(156, new ErrorCodeMsg()
            {
                SWMMIndex = 31,
                ErrorCode = 156,
                ErrorMesg = "ERROR 156: ambiguous station ID for Rain Gage %s"
            });

            ErrorMsg.Add(157, new ErrorCodeMsg()
            {
                SWMMIndex = 32,
                ErrorCode = 157,
                ErrorMesg = "ERROR 157: inconsistent rainfall format for Rain Gage %s"
            });

        }

    }
}
