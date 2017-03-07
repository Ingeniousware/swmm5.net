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

        #endregion standard methods at the original SWMM .dll

        #region new API methods

        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSimulationUnit(int type, ref int value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSimulationAnalysisSetting(int type, ref int value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSimulationParam(int type, ref double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_countObjects(int type, ref int count);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getObjectId(int type, int index, ref string id);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getNodeType(int index, ref int Ntype);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getLinkType(int index, ref int Ltype);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getLinkConnections(int index, ref int Node1, ref int Node2);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSubcatchOutConnection(int index, ref int type, ref int Index);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getNodeParam(int index, int Param, ref double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setNodeParam(int index, int Param, double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getLinkParam(int index, int Param, ref double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setLinkParam(int index, int Param, double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getLinkDirection(int index, ref string value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSubcatchParam(int index, int Param, ref double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setSubcatchParam(int index, int Param, double value);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSimulationDateTime(int timetype, ref string dtimestr);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setSimulationDateTime(int timetype, ref string dtimestr);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getCurrentDateTimeStr(ref string dtimestr);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getNodeResult(int index, int type, ref double result);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getLinkResult(int index, int type, ref double result);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_getSubcatchResult(int index, int type, ref double result);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setLinkSetting(int index, double setting);
        [DllImport("SWMM5Toolkit.dll")]
        private static extern int swmm_setNodeInflow(int index, double flowrate);



        #endregion new API methods


        #region public standard methods
        public int Run(string f1, string f2, string f3)
        {
            return swmm_run(f1, f2, f3);
        }

        public int Open(string f1, string f2, string f3)
        {
            return swmm_open(f1, f2, f3);
        }

        public int Start(int saveFlag)
        {
            return swmm_start(saveFlag);
        }

        public int Step(double elapsedTime)
        {
            return swmm_step(elapsedTime);
        }

        public int End()
        {
            return swmm_end();
        }

        public int Report()
        {
            return swmm_report();
        }

        public int GetMassBalErr(float runoffErr, float flowErr, float qualErr)
        {
            return swmm_getMassBalErr(runoffErr, flowErr, qualErr);
        }

        public int Close()
        {
            return swmm_close();
        }

        public int GetVersion()
        {
            return swmm_getVersion();
        }

        #endregion public standard methods

        #region new API methods
        public int GetSimulationUnit(int type, ref int value)
        {
            return swmm_getSimulationUnit(type, ref value);
        }

        public int GetSimulationAnalysisSetting(int type, ref int value)
        {
            return swmm_getSimulationAnalysisSetting(type, ref value);
        }

        public int GetSimulationParam(int type, ref double value)
        {
            return swmm_getSimulationParam(type, ref value);
        }

        public int CountObjects(int type, ref int count)
        {
            return swmm_countObjects(type, ref count);
        }

        public int GetObjectId(int type, int index, ref string id)
        {
            return swmm_getObjectId(type, index, ref id);
        }

        public int GetNodeType(int index, ref int Ntype)
        {
            return swmm_getNodeType(index, ref Ntype);
        }

        public int GetLinkType(int index, ref int Ltype)
        {
            return swmm_getLinkType(index, ref Ltype);
        }

        public int GetLinkConnections(int index, ref int Node1, ref int Node2)
        {
            return swmm_getLinkConnections(index, ref Node1, ref Node2);
        }

        public int GetSubcatchOutConnection(int index, ref int type, ref int Index)
        {
            return swmm_getSubcatchOutConnection(index, ref type, ref Index);
        }
        public int GetNodeParam(int index, int Param, ref double value)
        {
            return swmm_getNodeParam(index, Param, ref value);
        }

        public int SetNodeParam(int index, int Param, double value)
        {
            return swmm_setNodeParam(index, Param, value);
        }

        public int GetLinkParam(int index, int Param, ref double value)
        {
            return swmm_getLinkParam(index, Param, ref value);
        }

        public int SetLinkParam(int index, int Param, double value)
        {
            return swmm_setLinkParam(index, Param, value);
        }

        public int GetLinkDirection(int index, ref string value)
        {
            return swmm_getLinkDirection(index, ref value);
        }

        public int GetSubcatchParam(int index, int Param, ref double value)
        {
            return swmm_getSubcatchParam(index, Param, ref value);
        }

        public int SetSubcatchParam(int index, int Param, double value)
        {
            return swmm_setSubcatchParam(index, Param, value);
        }

        public int GetSimulationDateTime(int timetype, ref string dtimestr)
        {
            return swmm_getSimulationDateTime(timetype, ref dtimestr);
        }

        public int SetSimulationDateTime(int timetype, ref string dtimestr)
        {
            return swmm_setSimulationDateTime(timetype, ref dtimestr);
        }
        public int GetCurrentDateTimeStr(ref string dtimestr)
        {
            return swmm_getCurrentDateTimeStr(ref dtimestr);
        }
        public int GetNodeResult(int index, int type, ref double result)
        {
            return swmm_getNodeResult(index, type, ref result);
        }
        public int GetLinkResult(int index, int type, ref double result)
        {
            return swmm_getLinkResult(index, type, ref result);
        }
        public int GetSubcatchResult(int index, int type, ref double result)
        {
            return swmm_getSubcatchResult(index, type, ref result);
        }
        public int SetLinkSetting(int index, double setting)
        {
            return swmm_setLinkSetting(index, setting);
        }
        public int SetNodeInflow(int index, double flowrate)
        {
            return swmm_setNodeInflow(index, flowrate);
        }

        #endregion new API methods


    }
}
