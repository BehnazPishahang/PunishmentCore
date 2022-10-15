
namespace Anu.BaseInfo.ServiceModel.Types
{
    [System.ComponentModel.DisplayName("کيفيت امر ابلاغ در سرویس")]
    public class NoticeResultTypeContract
    {
        public NoticeResultTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع نتيجه")]
        public Anu.BaseInfo.Enumerations.NoticeResultType? ResultType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کدهاي انواع واحدهاي داراي دسترسي")]
        public string? UnitTypeAccess { get; set; }

            

    }
    }
