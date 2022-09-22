namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("SendPaymentRequestToSadadRequest")]
    public class SendPaymentRequestToSadadRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("اطلاعات ارسالی به سداد در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidFishNoContract? ThePBill4PaidFishNoContract { get; set; }
    }
}