
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("قسط تقسيط در سرویس")]
    public class PInstallmentDetailContract
    {
        public PInstallmentDetailContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ سر رسيد قسط")]
        public string? DueDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مبلغ قسط")]
        public long? InstallmentAmount { get; set; }

            
            
            [System.ComponentModel.DisplayName("مبلغ پرداخت شده")]
        public long? PayAmount { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ پرداخت قسط")]
        public string? PayDate { get; set; }

            

    }
    }
