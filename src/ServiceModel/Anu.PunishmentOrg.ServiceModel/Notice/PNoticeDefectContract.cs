
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("نقص پرونده جهت ابلاغ در سرویس")]
    public class PNoticeDefectContract
    {
        public PNoticeDefectContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان نقص")]
        public string? DefectTitle { get; set; }

            

    }
    }
