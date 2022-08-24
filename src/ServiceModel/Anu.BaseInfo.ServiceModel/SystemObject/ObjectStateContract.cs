
namespace Anu.BaseInfo.ServiceModel.SystemObject
{
    [System.ComponentModel.DisplayName("وضعيت اشياء در سرویس")]
    public class ObjectStateContract
    {
        public ObjectStateContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع وضعيت")]
        public Anu.BaseInfo.Enumerations.StateType? StateType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم هاي سيستم در سرویس")]
        public string? TheSystemFormContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شيء مربوط به وضعيت")]
        public string? TheSystemObjectContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }

            
            
            [System.ComponentModel.DisplayName("کدهاي انواع سطوح واحدهاي داراي دسترسي")]
        public string? UnitLevelAccess { get; set; }

            

    }
    }
