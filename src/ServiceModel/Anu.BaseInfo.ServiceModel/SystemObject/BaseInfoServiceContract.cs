
namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("اقلام سرویس اطلاعات پایه در سرویس")]
    public class BaseInfoServiceContract
    {
        public BaseInfoServiceContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("اشیاء سیستم در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemObjectContract? TheSystemObjectContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
