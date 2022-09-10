using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations.BaseInfo.SystemObject
{
    /// <summary>
    /// شروع ارور کدها از 10001
    /// </summary>
    public enum SystemObjectResult
    {
        BaseInfoServicesResult_Error_Title_Is_Required               = 10001,
        BaseInfoServicesResult_Error_Code_Is_Required                = 10002,
        BaseInfoServicesResult_Error_Code_Is_Not_Digit               = 10003,
        BaseInfoServicesResult_Error_SystemObject_Code_Is_Required   = 10004,
        BaseInfoServicesResult_Error_SystemObject_Code_Is_Not_Valid  = 10005,
        BaseInfoServicesResult_Error_BaseInfoRecord_Already_Commited = 10006
    }
}