
using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetPBill4PaidListByFishNo")]
    public class GetPBill4PaidListByFishNoRequest
    {
        public GetPBill4PaidListByFishNoRequest()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidFishNoContract? ThePBill4PaidFishNoContract { get; set; }
    }
    }
