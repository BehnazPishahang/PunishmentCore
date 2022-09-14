
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.Notice;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetPBill4PaidListByFishNo")]
    public class GetPBill4PaidListByFishNoResponse
    {
        public GetPBill4PaidListByFishNoResponse()
        {
            ThePBill4PaidInfoContract = new List<PBill4PaidInfoContract>();
        }

        [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
        public List<PBill4PaidInfoContract>? ThePBill4PaidInfoContract { get; set; }

            

    }
    }
