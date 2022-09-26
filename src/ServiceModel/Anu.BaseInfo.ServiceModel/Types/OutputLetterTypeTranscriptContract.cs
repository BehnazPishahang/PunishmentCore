
namespace Anu.BaseInfo.ServiceModel.Types
{
    [System.ComponentModel.DisplayName("رونوشت پيش فرض موضوع نامه صادره در سرویس")]
    public class OutputLetterTypeTranscriptContract
    {
        public OutputLetterTypeTranscriptContract()
        {
        }
            
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن رونوشت")]
        public string? TranscriptText { get; set; }

            

    }
    }
