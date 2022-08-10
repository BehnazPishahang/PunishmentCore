
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenContract
    {
        public PGravamenContract()
        {

        }

        [System.ComponentModel.DisplayName("متن آخرین ابلاغیه در مورد شکوائیه")]
        public virtual string? NoticeText { get; set; }

        [System.ComponentModel.DisplayName("شرح شکوائیه")]
        public virtual string? PetitionDescription { get; set; }

        [System.ComponentModel.DisplayName("مدارک و مستندات")]
        public virtual string? PetitionReasons { get; set; }

        [System.ComponentModel.DisplayName("موضوع شکایت")]
        public virtual string? PetitionSubject { get; set; }

        [System.ComponentModel.DisplayName("علت رد/نقض شکوائیه")]
        public virtual string? RejectReasonText { get; set; }

        [System.ComponentModel.DisplayName("نام خانوادگی گزارش دهنده")]
        public virtual string? ReporterFamily { get; set; }

        [System.ComponentModel.DisplayName("تلفن همراه گزارش دهنده")]
        public virtual string? ReporterMobilNumber { get; set; }

        [System.ComponentModel.DisplayName("نام گزارش دهنده")]
        public virtual string? ReporterName { get; set; }

        //public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }
        [System.ComponentModel.DisplayName("پرونده سازمان تعزیرات")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [System.ComponentModel.DisplayName("پیوست شکوائیه/گزارش مردمی")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenAttachment>? ThePGravamenAttachmentList { get; set; }

        [System.ComponentModel.DisplayName("شخص شکوائیه/گزارش مردمی")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenPerson>? ThePGravamenPersonList { get; set; }

        [System.ComponentModel.DisplayName("تخلفات شکوائیه/گزارش مردمی")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenViolation>? ThePGravamenViolationList { get; set; }

        [System.ComponentModel.DisplayName("واحد تعزیرات دریافت کننده اولیه شکوائ")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiveUnit { get; set; }

        [System.ComponentModel.DisplayName("شعبه ارجاع شونده")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

    }
}
