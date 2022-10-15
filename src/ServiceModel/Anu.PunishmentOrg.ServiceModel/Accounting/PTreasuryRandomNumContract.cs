
namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("شماره اتفاقي معادل شماره با معنا براي پرداختي خزانه در سرویس")]
    public class PTreasuryRandomNumContract
    {
        public PTreasuryRandomNumContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا با شماره مذکور پرداخت موفق انجام شده؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsPaid { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره وارد شده از طريق POS")]
        public string? POSNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره اتفاقي توليد شده جهت ارسال به خزانه")]
        public string? TreasuryNumber { get; set; }

            

    }
    }
