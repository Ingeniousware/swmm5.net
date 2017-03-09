using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum PumpCurveTypeEnum : byte
    {
      TYPE1_PUMP = 0,                      // flow varies stepwise with wet well volume 
      TYPE2_PUMP = 1,                      // flow varies stepwise with inlet depth  
      TYPE3_PUMP = 2,                      // flow varies with head delivered 
      TYPE4_PUMP = 3,                      // flow varies with inlet depth 
      IDEAL_PUMP                           // outflow equals inflow 


}
}
