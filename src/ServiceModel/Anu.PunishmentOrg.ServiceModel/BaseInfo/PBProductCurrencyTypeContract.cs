
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع کالا/ارز/خدمات در سرویس")]
    public class PBProductCurrencyTypeContract
    {
        public PBProductCurrencyTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالا اساسی است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsBasic { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالا ضروری است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsNecessary { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا کالا/ارز جزو کالا/ارز هاي ممنوعه است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsProhibitedGoods { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالا یارانه ایست؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsSubsidy { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد سطح کالا/ارز/خدمات")]
        public string? LevelCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد شناسه عمومي کالا")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز/خدمات")]
        public Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
