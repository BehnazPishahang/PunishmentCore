using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    /// <summary>
    /// شروع ارور کدها از 30009
    /// </summary>
    public enum PChaseLicenseReqResult
    {
        PChaseLicenseReq_IsNull = 30009,
        PChaseLicenseReq_ChaseTitle_IsNull = 300010,
        PChaseLicenseReq_ChaseLicenseRequestText_IsNull = 300011,
        PChaseLicenseReq_PChaseLicenseReqSuspectList_IsNull = 300012,
        PChaseLicenseReq_PChaseLicenseReqPlacesList_IsNull = 300013,
        PChaseLicenseReq_TheJudicialUnit_IsNull = 300014,
        PChaseLicenseReq_TheJudicialUnit_Code_IsNull = 300015,
        PChaseLicenseReq_PChaseLicenseReqSuspectList_Name_IsNull = 300016,
    }
}
