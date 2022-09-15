
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("اطلاعات شکوائیه/گزارش در سرویس")]
    public class PGravamenInfoContract
    {
        public PGravamenInfoContract()
        {
        }
            
            [System.ComponentModel.DisplayName("توضیحات تشکیل پرونده")]
        public string? FilingCaseDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضیحات اولیه")]
        public string? InitialCreationDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضیحات علت رد")]
        public string? RejectReasonDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضیحات وضعیت در حال بررسی")]
        public string? ReviewDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعیت")]
        public string? State { get; set; }

            

    }
    }
