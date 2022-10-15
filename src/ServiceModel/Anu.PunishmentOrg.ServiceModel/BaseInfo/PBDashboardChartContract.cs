
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("نوع نمودار داشبورد در سرویس")]
    public class PBDashboardChartContract
    {
        public PBDashboardChartContract()
        {
        }
            
            [System.ComponentModel.DisplayName("خصوصيات نمودار")]
        public string? ChartAttributes { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }

            
            
            [System.ComponentModel.DisplayName("کوئري")]
        public string? Query { get; set; }

            
            
            [System.ComponentModel.DisplayName("پارامترهاي کوئري")]
        public string? QueryParameters { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
