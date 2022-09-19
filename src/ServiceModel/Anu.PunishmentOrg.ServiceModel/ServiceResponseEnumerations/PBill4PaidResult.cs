using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations
{
    public enum GetPBill4PaidByFishNoResult
    {
        PBill4Paid_GetPBill4PaidByFishNo_Request_Is_Required                     = -30271,
        PBill4Paid_GetPBill4PaidByFishNo_ThePBill4PaidFishNoContract_Is_Required = -30272,
        PBill4Paid_GetPBill4PaidByFishNo_FishNo_Is_Required                      = -30273,
        PBill4Paid_GetPBill4PaidByFishNo_PBill4Paid_NotFound                     = -30274,
        PBill4Paid_GetPBill4PaidByFishNo_PBill4Paid_TheObjectState_Is_Null       = -30275,
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
        PBill4Paid_SendPaymentRequestToSadad_CallGetToken_HasError                       = -30299,
        PBill4Paid_SendPaymentRequestToSadad_GetToken_HasError                           = -302910,
    }

    public enum GetPBill4PaidListByNationalCodeResult
    {
        PBill4Paid_GetPBill4PaidListByNationalCode_Request_Is_Required                           = -30301,
        PBill4Paid_GetPBill4PaidListByNationalCode_ThePBill4PaidNationalCodeContract_Is_Required = -30302,
        PBill4Paid_GetPBill4PaidListByNationalCode_NationalCode_Is_Required                      = -30303,
        PBill4Paid_GetPBill4PaidListByNationalCode_PBill4Paid_NotFound                           = -30304,
    }

    public enum GetCountOfPaidPBill4PaidByNationalCodeResult
    {
        PBill4Paid_GetCountOfPaidPBill4PaidByNationalCode_Request_Is_Required                           = -30311,
        PBill4Paid_GetCountOfPaidPBill4PaidByNationalCode_ThePBill4PaidNationalCodeContract_Is_Required = -30312,
        PBill4Paid_GetCountOfPaidPBill4PaidByNationalCode_NationalCode_Is_Required                      = -30313,
        PBill4Paid_GetCountOfPaidPBill4PaidByNationalCode_PBill4Paid_NotFound                           = -30314,
    }
}