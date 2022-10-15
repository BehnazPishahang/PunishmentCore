
namespace Anu.BaseInfo.ServiceModel.Types
{
    [System.ComponentModel.DisplayName("حساب بانکي در سرویس")]
    public class AccountsContract
    {
        public AccountsContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره حساب")]
        public string? AccountNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ClientNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شبا حساب")]
        public string? IBAN { get; set; }

            
            
            [System.ComponentModel.DisplayName("ترتيب شماره شبا حساب در تسهيم")]
        public string? IBANOrder { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا شناسه واريز حساب خزانه ثابت است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsTreasuryConstant { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح مالک حساب")]
        public string? OwnerDescription { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه واريز براي حسابهاي خزانه")]
        public string? TreasuryID { get; set; }

            

    }
    }
