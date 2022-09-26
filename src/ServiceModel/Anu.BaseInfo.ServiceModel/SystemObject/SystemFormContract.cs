
namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("فرم هاي سيستم در سرویس")]
    public class SystemFormContract
    {
        public SystemFormContract()
        {
        }
            
            [System.ComponentModel.DisplayName("اسم dll")]
        public string? AssemblyName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مسير و نام فرم")]
        public string? ClassName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام انگليسي فرم")]
        public string? EnglishName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام فارسي فرم")]
        public string? FarsiName { get; set; }

            
            
            [System.ComponentModel.DisplayName("رديف در FormDesigner")]
        public string? FormDesignerId { get; set; }

            
            
            [System.ComponentModel.DisplayName("فرم هاي قابل رويت در فرم جاري")]
        public string? FromVisibleInForm { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلاس اصلي فرم")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemObjectContract? TheBaseObject { get; set; }

            
            
            [System.ComponentModel.DisplayName("فعاليت شروع شونده")]
        public string? WorkFlowStarter { get; set; }

            

    }
    }
