
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("مجازات دادنامه پرونده امحاء در سرویس")]
    public class PDestroyedJudgeBindingSbjContract
    {
        public PDestroyedJudgeBindingSbjContract()
        {
        }
            
            [System.ComponentModel.DisplayName("ميزان جزاي نقدي به ريال")]
        public decimal? PenaltyAmount { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان موضوع مجازات")]
        public string? SubjectTitle { get; set; }

            

    }
    }
