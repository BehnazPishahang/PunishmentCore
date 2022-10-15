
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("تاريخچه ابلاغيه هاي شکوائيه/گزارش مردمي در سرویس")]
    public class PGravamenNoticeHstContract
    {
        public PGravamenNoticeHstContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان صدور ابلاغيه")]
        public string? IssueDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن ابلاغيه")]
        public string? NoticeText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع ابلاغيه")]
        public Anu.PunishmentOrg.Enumerations.GravamenNoticeType? NoticeType { get; set; }

            

    }
    }
