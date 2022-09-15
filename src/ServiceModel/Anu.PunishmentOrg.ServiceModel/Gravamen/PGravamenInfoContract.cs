
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("اطلاعات شکوائیه/گزارش در سرویس")]
    public class PGravamenInfoContract
    {
        public PGravamenInfoContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("توضیحات تشکیل پرونده")]
        public string? FilingCaseDesc { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("توضیحات اولیه")]
        public string? InitialCreationDesc { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("توضیحات علت رد")]
        public string? RejectReasonDesc { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("توضیحات وضعیت در حال بررسی")]
        public string? ReviewDesc { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعیت")]
        public string? State { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاریخ ایجاد")]
        public string? CreateDateTime { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعیت اشیاء")]
        public Anu.BaseInfo.ServiceModel.SystemObject.ObjectStateContract TheObjectState { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پیگیری")]
        public string? FollowUpNo { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شرح شکوائيه")]
        public string? PetitionDescription { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("موضوع شکايت")]
        public string? PetitionSubject { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("پرونده تعزیرات")]
        public Anu.PunishmentOrg.ServiceModel.Case.PCaseContract ThePCase { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("واحد تعزيرات دريافت کننده اوليه شکوائيه")]

        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract TheReceiveUnit { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شعبه ارجاع شونده")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract TheReferUnit { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("علت رد/نقص شکوائيه")]
        public string? RejectReasonText { get; set; }
        


    }
}
