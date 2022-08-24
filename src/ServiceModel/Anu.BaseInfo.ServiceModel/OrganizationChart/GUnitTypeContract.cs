
namespace Anu.BaseInfo.ServiceModel.OrganizationChart
{
    [System.ComponentModel.DisplayName("نوع واحد سازماني در سرویس")]
    public class GUnitTypeContract
    {
        public GUnitTypeContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? Description { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
