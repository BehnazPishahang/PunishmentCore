
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("سازمان هاي تعامل کننده در مورد پرونده در سرویس")]
    public class PBExchangeUnitContract
    {
        public PBExchangeUnitContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع واحد از نظر کشف کالا/ارز قاچاق")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryUnitType? DiscoveryUnitType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا واحد نگهدارنده مال ميباشد؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsProductKeeper { get; set; }

            

    }
    }
