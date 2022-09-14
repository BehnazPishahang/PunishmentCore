using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class GetPBill4PaidListByNationalCodeResponse : IResponseMessage
    {
        public GetPBill4PaidListByNationalCodeResponse()
        {
            ThePBill4PaidInfoContract = new Page<List<PBill4PaidInfoContract>>();
            Result = new Result();
        }

        public Result Result { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public Page<List<PBill4PaidInfoContract>>? ThePBill4PaidInfoContract { get; set; }
    }
}