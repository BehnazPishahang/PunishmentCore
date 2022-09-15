using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class GetCountOfPaidPBill4PaidByNationalCodeResponse
    {
        public GetCountOfPaidPBill4PaidByNationalCodeResponse()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public GetCountOfPaidPBill4PaidByNationalCodeContract? TheGetCountOfPaidPBill4PaidByNationalCodeContract { get; set; }
    }
}