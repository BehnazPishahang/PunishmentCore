
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("شماره حساب واحد تعزيرات در سرویس")]
    public class PBUnitAccountsContract
    {
        public PBUnitAccountsContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع حساب")]
        public Anu.PunishmentOrg.Enumerations.AccountType? AccuntType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ClientNumber { get; set; }

            

    }
    }
