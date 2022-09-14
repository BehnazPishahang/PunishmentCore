using Anu.Commons.ServiceModel.ServicePaging;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class GetCountOfPaidPBill4PaidByNationalCodeRequest
    {
        public GetCountOfPaidPBill4PaidByNationalCodeRequest()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidNationalCodeContract? ThePBill4PaidNationalCodeContract { get; set; }
    }
}