
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("پیوست های مربوط به واحد صنفی بازرسی شده در سرویس")]
    public class PMobilePatrolsTUAttachmentContract
    {
        public PMobilePatrolsTUAttachmentContract()
        {
        }
            
            [System.ComponentModel.DisplayName("فايل پيوست")]
        public byte[]? DocFile { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            

    }
    }
