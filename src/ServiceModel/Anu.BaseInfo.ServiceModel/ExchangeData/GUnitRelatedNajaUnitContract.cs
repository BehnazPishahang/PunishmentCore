
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("واحد هاي ساير سازمان هاي مرتبط با واحد سازماني دروني در سرویس")]
    public class GUnitRelatedNajaUnitContract
    {
        public GUnitRelatedNajaUnitContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheNAJAUnitContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد سازماني در سرویس")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.unitContract? TheunitContract { get; set; }

            

    }
    }
