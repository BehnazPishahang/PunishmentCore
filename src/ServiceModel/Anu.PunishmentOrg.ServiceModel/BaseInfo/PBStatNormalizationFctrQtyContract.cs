
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("مقدار متغيرهاي نرمال ساز آمار در واحدهاي مختلف در سرویس")]
    public class PBStatNormalizationFctrQtyContract
    {
        public PBStatNormalizationFctrQtyContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مقدار")]
        public long? Quantity { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و زمان بروزرساني")]
        public string? RefreshDateTime { get; set; }

            

    }
    }
