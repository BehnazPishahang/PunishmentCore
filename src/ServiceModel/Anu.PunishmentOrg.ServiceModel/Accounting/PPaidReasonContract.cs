
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("علت پرداخت وجه به شخص در سرویس")]
    public class PPaidReasonContract
    {
        public PPaidReasonContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ پرداختي")]
        public long? PaidCost { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه مدرک عامل پرداخت")]
        public string? RelatedDocId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره مدرک عامل پرداخت")]
        public string? RelatedDocNo { get; set; }

            

    }
    }
