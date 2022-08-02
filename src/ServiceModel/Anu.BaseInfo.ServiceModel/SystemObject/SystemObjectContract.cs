
namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("اشیاء سیستم در سرویس")]
    public class SystemObjectContract
    {
        public SystemObjectContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اسم dll")]
        public string? AssemblyName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام انگليسي")]
        public string? EnglishName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اسم جدول مربوطه به کلاس")]
        public string? EnglishTableName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان فارسي")]
        public string? FarsiName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه شيء در ابزار تحليل")]
        public string? RoseId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شيء")]
        public Anu.BaseInfo.Enumerations.SystemObjectType? SystemObjectType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }

            

    }
    }
