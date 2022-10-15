
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("علت دريافت وجه از شخص در سرویس")]
    public class PCashReasonContract
    {
        public PCashReasonContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ اصلي")]
        public long? BaseAmount { get; set; }

            
            
            [System.ComponentModel.DisplayName("ميزان کاهش بدهي")]
        public long? DebtReductionValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تخفيف")]
        public Anu.BaseInfo.Enumerations.HaveNoHave? DiscountState { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه هاي موضوع لازم الاجراهاي قبلي متعلق به راي نقض شده توسط ديوان عدالت يا عالي")]
        public string? OldCaseBindingIDs { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ قابل دريافتي")]
        public long? PaidCost { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه مدرک عامل دريافت")]
        public string? RelatedDocId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره مدرک عامل دريافت")]
        public string? RelatedDocNo { get; set; }

            

    }
    }
