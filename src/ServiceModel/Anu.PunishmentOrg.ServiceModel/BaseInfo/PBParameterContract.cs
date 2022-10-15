
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("پارامترهاي تعزيراتي در سرویس")]
    public class PBParameterContract
    {
        public PBParameterContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه اعتبار")]
        public string? EndDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? ParamDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("مقدار پارامتر رشته اي")]
        public string? ParameterStringValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع پارامتر")]
        public Anu.PunishmentOrg.Enumerations.PUParameter? ParameterType { get; set; }

            
            
            [System.ComponentModel.DisplayName("مقدار پارامتر عددي")]
        public long? ParameterValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع اعتبار")]
        public string? StartDate { get; set; }

            

    }
    }
