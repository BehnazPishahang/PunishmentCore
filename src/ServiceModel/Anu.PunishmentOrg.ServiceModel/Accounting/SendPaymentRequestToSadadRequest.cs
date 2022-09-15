namespace Anu.PunishmentOrg.Api.Accounting
{
    public class SendPaymentRequestToSadadRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidFishNoContract? ThePBill4PaidFishNoContract { get; set; }
    }
}