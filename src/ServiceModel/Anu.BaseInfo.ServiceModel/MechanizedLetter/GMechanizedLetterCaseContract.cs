
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرویس")]
    public class GMechanizedLetterCaseContract
    {
        public GMechanizedLetterCaseContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مبداء/مقصد")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterCaseLocation? CaseLocation { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه پرونده(يا مدرک اصلي مشابه) مربوطه")]
        public string? RelatedCaseID { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره پرونده(يا مدرک اصلي مشابه) نامه")]
        public string? RelatedCaseNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان/شرح پرونده(يا مدرک اصلي مشابه) نامه")]
        public string? RelatedCaseTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم پرونده(يا مدرک اصلي مشابه) مربوطه")]
        public string? TheRelatedCaseForm { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلاس پرونده(يا مدرک اصلي مشابه) مربوطه")]
        public string? TheSystemObjectContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد مربوط به پرونده(يا مدرک اصلي مشابه) مربوطه")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.unitContract? TheunitContract { get; set; }

            

    }
    }
