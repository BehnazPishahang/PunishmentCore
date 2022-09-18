
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Notice;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetPBill4PaidByFishNo")]
    public class GetPBill4PaidByFishNoResponse : IResponseMessage
    {
        public GetPBill4PaidByFishNoResponse()
        {
            Result = new Result();
            ThePBill4PaidInfoContract = new PBill4PaidInfoContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public PBill4PaidInfoContract? ThePBill4PaidInfoContract { get; set; }

        public Result Result { get; set; }

    }
    }
