using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum GetPaymentInfoResult
    {
        PBill4Paid_GetPaymentInfo_Request_Is_Required                      = -30261,
        PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required  = -30262,
        PBill4Paid_GetPaymentInfo_FishNo_Is_Required                       = -30263,
        PBill4Paid_GetPaymentInfo_PBill4Pay_NotFound                       = -30264,
    }
}