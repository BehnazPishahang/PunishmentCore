using Anu.Commons.ServiceModel.ServicePaging;
using Anu.PunishmentOrg.ServiceModel.Accounting;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("GetCountOfPaidPBill4PaidByNationalCodeRequest")]
    public class GetCountOfPaidPBill4PaidByNationalCodeRequest
    {
        public GetCountOfPaidPBill4PaidByNationalCodeRequest()
        {
            ThePBill4PaidNationalCodeContract = new Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidNationalCodeContract();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidNationalCodeContract? ThePBill4PaidNationalCodeContract { get; set; }
    }
}