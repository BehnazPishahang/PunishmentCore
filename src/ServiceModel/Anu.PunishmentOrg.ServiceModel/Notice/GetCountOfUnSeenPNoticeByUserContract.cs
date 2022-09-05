
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("GetCountOfUnSeenPNoticeByUserContract")]
    public class GetCountOfUnSeenPNoticeByUserContract
    {
        public GetCountOfUnSeenPNoticeByUserContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد کل ابلاغیه‌های شخص")]
        public long? TotalCountPNoticeOfUser { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد ابلاغیه‌های مشاهده نشده از سایت")]
        public long? CountUnSeenPNoticeByUser { get; set; }



        [System.ComponentModel.DisplayName("تعداد ابلاغیه‌های مشاهده شده شخص")]
        public long? CountSeenedOfPNoticeByUser { get; set; }



        [System.ComponentModel.DisplayName("کد ملی ابلاغ شونده")]
        public string? NoticePersonNationalityCode { get; set; }

    }
}
