
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در سرویس")]
    public class NAJAUnitContract
    {
        public NAJAUnitContract()
        {
        TheChildUnitList = new List<Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract>();

        TheGFESUserAccessContractList = new List<string>();

        TheGUnitRelatedNajaUnitContractList = new List<Anu.BaseInfo.ServiceModel.ExchangeData.GUnitRelatedNajaUnitContract>();

        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آدرس")]
        public string? Address { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد يکتاي واحد در سامانه")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("فيلد موقت 1")]
        public string? Desc1 { get; set; }

            
            
            [System.ComponentModel.DisplayName("فيلد موقت 2")]
        public string? Desc2 { get; set; }

            
            
            [System.ComponentModel.DisplayName("فيلد موقت 3")]
        public string? Desc3 { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد سطح واحد")]
        public string? LevelCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد واحد در سازمان مربوطه")]
        public string? NAJACode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحدهاي زيردست")]
        public List<Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract>? TheChildUnitList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان سازمان تعامل کننده در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.GExchangeUnitTitleContract? TheGExchangeUnitTitleContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("دسترسی کاربر خارج از سازمان در سرویس")]
        public List<string>? TheGFESUserAccessContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد هاي ساير سازمان هاي مرتبط با واحد سازماني دروني در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.ExchangeData.GUnitRelatedNajaUnitContract>? TheGUnitRelatedNajaUnitContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد بالادست")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheParentUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان واحد")]
        public string? UnitName { get; set; }

            

    }
    }
