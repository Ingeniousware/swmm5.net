﻿using System;
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

            ErrorMsg.Add(158, new ErrorCodeMsg()
            {
                SWMMIndex = 33,
                ErrorCode = 158,
                ErrorMesg = "ERROR 158: time series for Rain Gage %s is also used by another object"
            });

            ErrorMsg.Add(159, new ErrorCodeMsg()
            {
                SWMMIndex = 34,
                ErrorCode = 159,
                ErrorMesg = "ERROR 159: recording interval greater than time series interval for Rain Gage %s"
            });

            ErrorMsg.Add(161, new ErrorCodeMsg()
            {
                SWMMIndex = 35,
                ErrorCode = 161,
                ErrorMesg = "ERROR 161: cyclic dependency in treatment functions at node %s"
            });

            ErrorMsg.Add(171, new ErrorCodeMsg()
            {
                SWMMIndex = 36,
                ErrorCode = 171,
                ErrorMesg = "ERROR 171: Curve %s has invalid or out of sequence data"
            });

            ErrorMsg.Add(173, new ErrorCodeMsg()
            {
                SWMMIndex = 37,
                ErrorCode = 173,
                ErrorMesg = "ERROR 173: Time Series %s has its data out of sequence"
            });

            ErrorMsg.Add(181, new ErrorCodeMsg()
            {
                SWMMIndex = 38,
                ErrorCode = 181,
                ErrorMesg = "ERROR 181: invalid Snow Melt Climatology parameters"
            });

            ErrorMsg.Add(182, new ErrorCodeMsg()
            {
                SWMMIndex = 39,
                ErrorCode = 182,
                ErrorMesg = "ERROR 182: invalid parameters for Snow Pack %s"
            });

            ErrorMsg.Add(183, new ErrorCodeMsg()
            {
                SWMMIndex = 40,
                ErrorCode = 183,
                ErrorMesg = "ERROR 183: no type specified for LID %s"
            });

            ErrorMsg.Add(184, new ErrorCodeMsg()
            {
                SWMMIndex = 41,
                ErrorCode = 184,
                ErrorMesg = "ERROR 184: missing layer for LID %s"
            });

            ErrorMsg.Add(185, new ErrorCodeMsg()
            {
                SWMMIndex = 42,
                ErrorCode = 185,
                ErrorMesg = "ERROR 185: invalid parameter value for LID %s"
            });

            ErrorMsg.Add(186, new ErrorCodeMsg()
            {
                SWMMIndex = 43,
                ErrorCode = 186,
                ErrorMesg = "ERROR 186: invalid parameter value for LID placed in Subcatchment %s"
            });

            ErrorMsg.Add(186, new ErrorCodeMsg()
            {
                SWMMIndex = 43,
                ErrorCode = 186,
                ErrorMesg = "ERROR 186: invalid parameter value for LID placed in Subcatchment %s"
            });

            ErrorMsg.Add(187, new ErrorCodeMsg()
            {
                SWMMIndex = 44,
                ErrorCode = 187,
                ErrorMesg = "ERROR 187: LID area exceeds total area for Subcatchment %s"
            });

            ErrorMsg.Add(188, new ErrorCodeMsg()
            {
                SWMMIndex = 45,
                ErrorCode = 188,
                ErrorMesg = "ERROR 188: LID capture area exceeds total impervious area for Subcatchment %s"
            });

            ErrorMsg.Add(191, new ErrorCodeMsg()
            {
                SWMMIndex = 45,
                ErrorCode = 191,
                ErrorMesg = "ERROR 191: simulation start date comes after ending date"
            });

            ErrorMsg.Add(193, new ErrorCodeMsg()
            {
                SWMMIndex = 46,
                ErrorCode = 193,
                ErrorMesg = "ERROR 193: report start date comes after ending date"
            });

            ErrorMsg.Add(195, new ErrorCodeMsg()
            {
                SWMMIndex = 47,
                ErrorCode = 195,
                ErrorMesg = "ERROR 195: reporting time step or duration is less than routing time step"
            });

            ErrorMsg.Add(200, new ErrorCodeMsg()
            {
                SWMMIndex = 48,
                ErrorCode = 200,
                ErrorMesg = "ERROR 200: one or more errors in input file"
            });

            ErrorMsg.Add(201, new ErrorCodeMsg()
            {
                SWMMIndex = 49,
                ErrorCode = 201,
                ErrorMesg = "ERROR 201: too many characters in input line"
            });

            ErrorMsg.Add(203, new ErrorCodeMsg()
            {
                SWMMIndex = 50,
                ErrorCode = 203,
                ErrorMesg = "ERROR 203: too few items"
            });

            ErrorMsg.Add(205, new ErrorCodeMsg()
            {
                SWMMIndex = 51,
                ErrorCode = 205,
                ErrorMesg = "ERROR 205: invalid keyword %s"
            });

            ErrorMsg.Add(207, new ErrorCodeMsg()
            {
                SWMMIndex = 52,
                ErrorCode = 207,
                ErrorMesg = "ERROR 207: duplicate ID name %s"
            });

            ErrorMsg.Add(209, new ErrorCodeMsg()
            {
                SWMMIndex = 53,
                ErrorCode = 209,
                ErrorMesg = "ERROR 209: undefined object %s"
            });

            ErrorMsg.Add(211, new ErrorCodeMsg()
            {
                SWMMIndex = 54,
                ErrorCode = 211,
                ErrorMesg = "ERROR 211: invalid number %s"
            });

            ErrorMsg.Add(213, new ErrorCodeMsg()
            {
                SWMMIndex = 55,
                ErrorCode = 213,
                ErrorMesg = "ERROR 213: invalid date/time %s"
            });

            ErrorMsg.Add(217, new ErrorCodeMsg()
            {
                SWMMIndex = 56,
                ErrorCode = 217,
                ErrorMesg = "ERROR 217: control rule clause invalid or out of sequence"
            });

            ErrorMsg.Add(219, new ErrorCodeMsg()
            {
                SWMMIndex = 57,
                ErrorCode = 219,
                ErrorMesg = "ERROR 219: data provided for unidentified transect"
            });

            ErrorMsg.Add(221, new ErrorCodeMsg()
            {
                SWMMIndex = 58,
                ErrorCode = 221,
                ErrorMesg = "ERROR 221: transect station out of sequence"
            });

            ErrorMsg.Add(223, new ErrorCodeMsg()
            {
                SWMMIndex = 59,
                ErrorCode = 223,
                ErrorMesg = "ERROR 223: Transect %s has too few stations"
            });

            ErrorMsg.Add(225, new ErrorCodeMsg()
            {
                SWMMIndex = 60,
                ErrorCode = 225,
                ErrorMesg = "ERROR 225: Transect %s has too many stations"
            });

            ErrorMsg.Add(227, new ErrorCodeMsg()
            {
                SWMMIndex = 61,
                ErrorCode = 227,
                ErrorMesg = "ERROR 227: Transect %s has no Manning's N"
            });

            ErrorMsg.Add(229, new ErrorCodeMsg()
            {
                SWMMIndex = 62,
                ErrorCode = 229,
                ErrorMesg = "ERROR 229: Transect %s has invalid overbank locations"
            });

            ErrorMsg.Add(231, new ErrorCodeMsg()
            {
                SWMMIndex = 63,
                ErrorCode = 231,
                ErrorMesg = "ERROR 231: Transect %s has no depth"
            });

            ErrorMsg.Add(233, new ErrorCodeMsg()
            {
                SWMMIndex = 64,
                ErrorCode = 233,
                ErrorMesg = "ERROR 233: invalid treatment function expression"
            });

            ErrorMsg.Add(301, new ErrorCodeMsg()
            {
                SWMMIndex = 65,
                ErrorCode = 301,
                ErrorMesg = "ERROR 301: files share same names"
            });

            ErrorMsg.Add(303, new ErrorCodeMsg()
            {
                SWMMIndex = 66,
                ErrorCode = 303,
                ErrorMesg = "ERROR 303: cannot open input file"
            });

            ErrorMsg.Add(305, new ErrorCodeMsg()
            {
                SWMMIndex = 67,
                ErrorCode = 305,
                ErrorMesg = "ERROR 305: cannot open report file"
            });

            ErrorMsg.Add(307, new ErrorCodeMsg()
            {
                SWMMIndex = 68,
                ErrorCode = 307,
                ErrorMesg = "ERROR 307: cannot open binary results file"
            });

            ErrorMsg.Add(309, new ErrorCodeMsg()
            {
                SWMMIndex = 69,
                ErrorCode = 309,
                ErrorMesg = "ERROR 309: error writing to binary results file"
            });

            ErrorMsg.Add(311, new ErrorCodeMsg()
            {
                SWMMIndex = 70,
                ErrorCode = 311,
                ErrorMesg = "ERROR 311: error reading from binary results file"
            });


        }

    }
}
