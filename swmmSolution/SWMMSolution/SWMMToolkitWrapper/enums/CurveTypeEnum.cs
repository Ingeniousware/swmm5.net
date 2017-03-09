using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum CurveTypeEnum : byte
    {
        STORAGE_CURVE = 0,                   // surf. area v. depth for storage node 
        DIVERSION_CURVE = 1,                 // diverted flow v. inflow for divider node 
        TIDAL_CURVE = 2,                     // water elev. v. hour of day for outfall 
        RATING_CURVE = 3,                    // flow rate v. head for outlet link 
        CONTROL_CURVE = 4,                   // control setting v. controller variable 
        SHAPE_CURVE = 5,                     // width v. depth for custom x-section 
        PUMP1_CURVE = 6,                     // flow v. wet well volume for pump 
        PUMP2_CURVE = 7,                     // flow v. depth for pump (discrete) 
        PUMP3_CURVE = 8,                     // flow v. head for pump (continuous) 
        PUMP4_CURVE                          // flow v. depth for pump (continuous)
    }
}
