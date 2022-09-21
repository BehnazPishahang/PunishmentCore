using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetCountOfPaidPBill4PaidByNationalCodeResponse")]
    public class GetCountOfPaidPBill4PaidByNationalCodeResponse : IResponseMessage
    {
        public GetCountOfPaidPBill4PaidByNationalCodeResponse()
        {
            Result = new Result();
            TheGetCountOfPaidPBill4PaidByNationalCodeContract = new GetCountOfPaidPBill4PaidByNationalCodeContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public GetCountOfPaidPBill4PaidByNationalCodeContract? TheGetCountOfPaidPBill4PaidByNationalCodeContract { get; set; }
        public Result Result { get; set; }
    }
}