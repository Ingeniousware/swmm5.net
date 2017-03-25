using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMToolkitWrapper.enums
{
    public enum EGetAndSetLinkParam: byte
    {
        /// <summary>
        /// offset1
        /// </summary>
        offset1 = 0,
        /// <summary>
        /// offset2
        /// </summary>
        offset2 = 1,
        /// <summary>
        /// Time step for lengthening (sec)
        /// </summary>
        q0 = 2,
        /// <summary>
        /// qLimit
        /// </summary>
        qLimit = 3,
        /// <summary>
        /// cLossInlet
        /// </summary>
        cLossInlet = 4,
        /// <summary>
        /// cLossOutlet
        /// </summary>
        cLossOutlet = 5,
        /// <summary>
        /// cLossAvg
        /// </summary>
        cLossAvg
    }
}
