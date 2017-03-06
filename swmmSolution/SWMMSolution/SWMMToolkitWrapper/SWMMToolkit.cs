using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper
{
    public class SWMMToolkit
    {

        #region standard methods at the original SWMM .dll

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_run(string f1, string f2, string f3);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_open(string f1, string f2, string f3);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_start(int saveFlag);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_step(double elapsedTime);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_end();

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_report();

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getMassBalErr(float runoffErr, float flowErr, float qualErr);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_close();

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getVersion();

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getError(string errMsg, int msgLen);

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getWarnings();

        #endregion standard methods at the original SWMM .dll


        public int GetNodeValue(string f1, string f2, string f3)
        {
            return swmm_run(f1, f2, f3);
        }

    }
}
