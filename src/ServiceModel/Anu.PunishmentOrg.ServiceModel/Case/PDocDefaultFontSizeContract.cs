
namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("اندازه پيش فرض فونت متن ها مدارک شعبه در سرویس")]
    public class PDocDefaultFontSizeContract
    {
        public PDocDefaultFontSizeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اندازه پيش فرض فونت")]
        public long? FontSize { get; set; }

            

    }
    }
