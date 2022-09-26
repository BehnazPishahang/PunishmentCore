
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

            
            
            [System.ComponentModel.DisplayName("فرم هاي سيستم در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemFormContract? TheSystemFormContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شيء مربوط به وضعيت")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemObjectContract? TheSystemObjectContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            
            
            [System.ComponentModel.DisplayName("کدهاي انواع سطوح واحدهاي داراي دسترسي")]
        public string? UnitLevelAccess { get; set; }

            

    }
    }
