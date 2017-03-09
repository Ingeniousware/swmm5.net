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



        }

    }
}
