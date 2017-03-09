using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum InputOptionTypeEnum : byte
    {
        FLOW_UNITS = 0,
        INFIL_MODEL = 1,
        ROUTE_MODEL = 2,
        START_DATE = 3,
        START_TIME,
        END_DATE = 5,
        END_TIME = 6,
        REPORT_START_DATE = 7,
        REPORT_START_TIME = 8,
        SWEEP_START = 9,
        SWEEP_END = 10,
        START_DRY_DAYS = 11,
        WET_STEP = 12,
        DRY_STEP = 13,
        ROUTE_STEP = 14,
        REPORT_STEP = 15,
        ALLOW_PONDING = 16,
        INERT_DAMPING = 17,
        SLOPE_WEIGHTING = 18,
        VARIABLE_STEP = 19,
        NORMAL_FLOW_LTD = 20,
        LENGTHENING_STEP = 21,
        MIN_SURFAREA = 22,
        COMPATIBILITY = 23,
        SKIP_STEADY_STATE = 24,
        TEMPDIR = 25,
        IGNORE_RAINFALL = 26,
        FORCE_MAIN_EQN = 27,
        LINK_OFFSETS = 28,
        MIN_SLOPE = 29,
        IGNORE_SNOWMELT = 30,
        IGNORE_GWATER = 31,
        IGNORE_ROUTING = 32,
        IGNORE_QUALITY = 33,
        MAX_TRIALS = 34,
        HEAD_TOL = 35,
        SYS_FLOW_TOL = 36,
        LAT_FLOW_TOL = 37,
        IGNORE_RDII = 38,
        MIN_ROUTE_STEP = 39,
        NUM_THREADS
    }
}
