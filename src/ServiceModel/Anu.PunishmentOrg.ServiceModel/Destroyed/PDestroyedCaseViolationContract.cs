
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("تخلف پرونده امحاء در سرویس")]
    public class PDestroyedCaseViolationContract
    {
        public PDestroyedCaseViolationContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان موضوع تخلف")]
        public string? SubjectTitle { get; set; }

            

    }
    }
