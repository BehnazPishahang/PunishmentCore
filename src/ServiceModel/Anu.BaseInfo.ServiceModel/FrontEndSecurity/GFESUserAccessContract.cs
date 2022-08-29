
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("دسترسی کاربر خارج از سازمان در سرویس")]
    public class GFESUserAccessContract
    {
        public GFESUserAccessContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("از تاريخ و ساعت")]
        public string? FromDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن امضاي كاربر")]
        public string? SignText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع دسترسي کاربر خارج از سازمان در سرویس")]
        public string? TheGFESUserAccessTypeContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کاربر خارج از سازمان در سرویس")]
        public string? TheGFESUserContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheNAJAUnitContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تا تاريخ و ساعت")]
        public string? ToDateTime { get; set; }

            

    }
    }
