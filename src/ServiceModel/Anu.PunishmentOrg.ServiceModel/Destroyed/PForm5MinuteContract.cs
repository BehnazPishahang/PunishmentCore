
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("صورتجلسه اوراق امحايي-فرم 5 در سرویس")]
    public class PForm5MinuteContract
    {
        public PForm5MinuteContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني بايگاني")]
        public string? ArchiveAddress { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("مساحت آزاد شده")]
        public long? FreeArea { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ تنظيم")]
        public string? IssueDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ نامه موافقت معاونت اسناد ملي")]
        public string? LetterDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره نامه موافقت معاونت اسناد ملي")]
        public string? LetterNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرم")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("جمع کل اوراق امحايي")]
        public long? PageSum { get; set; }

            

    }
    }
