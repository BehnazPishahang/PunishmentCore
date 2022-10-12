
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("صورتجلسه تصميمات کميته اجرايي-فرم 3 در سرویس")]
    public class PDestroyedMinuteContract
    {
        public PDestroyedMinuteContract()
        {
        }
            
            [System.ComponentModel.DisplayName("زمان تاييد")]
        public string? ConfirmDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ جلسه")]
        public string? MeetingDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره صورتجلسه")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ اظهارنظر شوراي تشخيص اسناد سازمان")]
        public string? OrgConfirmDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ ارسال به شوراي تشخيص اسناد سازمان جهت اظهارنظر")]
        public string? SendDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت شروع جلسه")]
        public string? StartTime { get; set; }

            

    }
    }
