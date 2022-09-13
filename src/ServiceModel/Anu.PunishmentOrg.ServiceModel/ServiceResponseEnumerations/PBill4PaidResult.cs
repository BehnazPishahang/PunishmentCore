using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum GetPaymentInfoResult
    {
        PBill4Paid_GetPaymentInfo_Request_Is_Required                     = -30271,
        PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required = -30272,
        PBill4Paid_GetPaymentInfo_FishNo_Is_Required                      = -30273,
        PBill4Paid_GetPaymentInfo_PBill4Paid_NotFound                     = -30274,
        PBill4Paid_GetPaymentInfo_PBill4Paid_TheObjectState_Is_Null       = -30275,
    }
}