
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("آخرين وضعيت صورتجلسه کشف در سرویس")]
    public class PDiscoveryMinutesStateContract
    {
        public PDiscoveryMinutesStateContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ وقت")]
        public string? RegisterDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت تجديد نظر")]
        public string? RevisionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام واحد")]
        public string? UnitName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره واحد رسيدگي کننده")]
        public string? UnitNo { get; set; }

            

    }
    }
