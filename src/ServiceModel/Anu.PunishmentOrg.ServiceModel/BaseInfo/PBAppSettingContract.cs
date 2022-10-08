
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("تنظیمات اپلیکیشن تعزیرات در سرویس")]
    public class PBAppSettingContract
    {
        public PBAppSettingContract()
        {
        }
            
            [System.ComponentModel.DisplayName("مقدار")]
        public string? Key { get; set; }

            
            
            [System.ComponentModel.DisplayName("کلید")]
        public string? Value { get; set; }

            

    }
    }
