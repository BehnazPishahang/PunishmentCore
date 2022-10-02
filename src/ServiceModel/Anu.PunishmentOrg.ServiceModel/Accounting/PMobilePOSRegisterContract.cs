
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("رجيستر کردن POS سيار در سرویس")]
    public class PMobilePOSRegisterContract
    {
        public PMobilePOSRegisterContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره پذيرنده")]
        public string? ReceiverNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پايانه")]
        public string? TerminalID { get; set; }

            

    }
    }
