
namespace Anu.PunishmentOrg.ServiceModel.BaseInfo
{
    [System.ComponentModel.DisplayName("سابقه ورود کاربران سازمان تعزیرات حکومتی در سرویس")]
    public class PBPuoUsersHistoryContract
    {
        public PBPuoUsersHistoryContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تعداد ارسال کد در روز")]
        public long? CountCodePerDay { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد ارسالی با اس ام اس")]
        public string? DynomicPassword { get; set; }

            
            
            [System.ComponentModel.DisplayName("پایان مهلت استفاده از کد")]
        public string? ExpiredCodeDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان ارسال کد")]
        public string? SendCodeDateTime { get; set; }

            

    }
    }
