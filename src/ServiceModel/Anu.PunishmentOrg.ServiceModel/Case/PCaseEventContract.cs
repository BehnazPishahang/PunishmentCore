
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("رخدادهاي پرونده تعزيرات در سرویس")]
    public class PCaseEventContract
    {
        public PCaseEventContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ايجاد")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خلاصه رخداد")]
        public string? EventAbstract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ رخداد")]
        public string? EventDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نحوه ايجاد رخداد")]
        public Anu.BaseInfo.Enumerations.HowToMakeEvent? HowToMakeEvent { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا قابل رويت براي ذي سمت مي باشد")]
        public Anu.BaseInfo.Enumerations.YesNo? IsCasePersonSee { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه مدرک مربوطه")]
        public string? RelatedDocId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره مدرک مربوطه")]
        public string? RelatedDocNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            

    }
    }
