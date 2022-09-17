
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("GetPersonPGravamenStatisticContract")]
    public class GetPersonPGravamenStatisticContract
    {
        public GetPersonPGravamenStatisticContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد کل شکوائیه‌های شخص")]
        public long? TotalCountPGravamenPerson { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تعداد شکوائیه‌های رد شده")]
        public long? CountRejectedPGravamenPerson { get; set; }



        [System.ComponentModel.DisplayName("تعداد شکوائیه‌های در حال بررسی")]
        public long? CountPendingPGravamenPerson { get; set; }


        [System.ComponentModel.DisplayName("کد ملی ابلاغ شونده")]
        public string? PersonNationalityCode { get; set; }

    }
}
