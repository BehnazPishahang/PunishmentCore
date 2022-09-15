using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.Api.Accounting
{
    public class SendPaymentRequestToSadadResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public SendPaymentRequestToSadadResponse()
        {
            Result = new Result();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه پرداخت در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Accounting.PBill4PaidTokenContract? ThePBill4PaidTokenContract { get; set; }
    }
}