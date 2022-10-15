
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("شیء قلم در سرویس")]
    public class GMechanizedLetTypFldObjectContract
    {
        public GMechanizedLetTypFldObjectContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
