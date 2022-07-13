using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServiceResponse
{
    public enum AnuResult
    {
        Successful = 10000,
        Error = 10005,
        UserName_Or_PassWord_Is_Not_Valid = 10010,
        UserName_Or_PassWord_Is_Not_Entered = 10012
    }
}
