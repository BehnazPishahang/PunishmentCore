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

    public enum SendPaymentRequestToSadadResult
    {
        PBill4Paid_SendPaymentRequestToSadad_Request_Is_Required                         = -30291,
        PBill4Paid_SendPaymentRequestToSadad_ThePBill4PaidFishNoContract_Is_Required     = -30292,
        PBill4Paid_SendPaymentRequestToSadad_FishNo_Is_Required                          = -30293,
        PBill4Paid_SendPaymentRequestToSadad_PBill4Paid_NotFound                         = -30294,
        PBill4Paid_SendPaymentRequestToSadad_IBAN_NotFound                               = -30295,
        PBill4Paid_SendPaymentRequestToSadad_IBAN_NotValid                               = -30296,
        PBill4Paid_SendPaymentRequestToSadad_TreasuryID_NotFound                         = -30297,
        PBill4Paid_SendPaymentRequestToSadad_TotalPaidCost_NotFound                      = -30298,
        PBill4Paid_SendPaymentRequestToSadad_CallGetToken_HasError                       = -30298,
        PBill4Paid_SendPaymentRequestToSadad_GetToken_HasError                           = -30298,
    }
}