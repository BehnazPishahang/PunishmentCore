
namespace Anu.BaseInfo.ServiceModel.Types
{
    [System.ComponentModel.DisplayName("انواع ابلاغ در سرویس")]
    public class GNoticeTypeContract
    {
        public GNoticeTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
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
