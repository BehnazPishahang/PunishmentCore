
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("تقسيط جزاي نقدي در سرویس")]
    public class PInstallmentContract
    {
        public PInstallmentContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مقام تاييد کننده")]
        public Anu.PunishmentOrg.Enumerations.ConfirmerExecutionDocsType? ConfirmerPostType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه اقساط")]
        public string? EndDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("مشخصات ضمانت نامه تقسيط")]
        public string? InstallmentWarrantiesInfo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد اقساط")]
        public long? NumInstallment { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ پرداخت اوليه")]
        public long? PrePayAmount { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع اقساط")]
        public string? StartDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کل مبلغي که بايد قسط بندي شود")]
        public long? TotalAmount { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کل مبلغي داده شده تاکنون")]
        public long? TotalPaidAmount { get; set; }

            

    }
    }
