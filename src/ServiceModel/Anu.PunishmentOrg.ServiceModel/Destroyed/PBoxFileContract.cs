
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("گوني/کارتن نگه دارنده پرونده هاي امحاء در سرویس")]
    public class PBoxFileContract
    {
        public PBoxFileContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره يکتاي گوني/کارتن")]
        public string? BoxFileNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سال مختومه شدن نهايي پرونده هاي درون گوني/کارتن")]
        public string? EndYear { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره طبقه پرونده ها درون گوني/کارتن از نظر امحاء")]
        public Anu.PunishmentOrg.Enumerations.DestroyedCaseStep? StepNo { get; set; }

            

    }
    }
