
namespace Anu.BaseInfo.ServiceModel.Attachment
{
    [System.ComponentModel.DisplayName("مدارک پيوست در سرویس")]
    public class GAttachmentRelatedObjectContract
    {
        public GAttachmentRelatedObjectContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه مدرک مکانيزه مربوطه")]
        public string? RelatedObjectId { get; set; }

            

    }
    }
