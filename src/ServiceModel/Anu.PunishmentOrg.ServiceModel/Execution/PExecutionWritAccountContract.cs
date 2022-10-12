
namespace Anu.PunishmentOrg.ServiceModel.Execution
{
    [System.ComponentModel.DisplayName("شماره حساب هاي مسدودي در قرار اجراي احکام در سرویس")]
    public class PExecutionWritAccountContract
    {
        public PExecutionWritAccountContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره حساب جهت مسدود شدن آن")]
        public string? AccountNo { get; set; }

            

    }
    }
