
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenContract
    {
        public PGravamenContract()
        {
            TheGAttachmentContractList = new List<Anu.BaseInfo.ServiceModel.Attachment.GAttachmentContract>();

            ThePGravamenPersonContractList = new List<Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenPersonContract>();

            ThePGravamenViolationContractList = new List<Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenViolationContract>();

        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پيگيري")]
        public string? FollowUpNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شکوائيه/گزارش مردمي")]
        public Anu.PunishmentOrg.Enumerations.GravamenOrReport? GravamenOrReport { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نحوه اخذ اطلاعات")]
        public Anu.PunishmentOrg.Enumerations.PU135OrWebSite? HowDataType { get; set; }



        [System.ComponentModel.DisplayName("متن آخرين ابلاغيه در مورد شکوائيه")]
        public string? NoticeText { get; set; }



        [System.ComponentModel.DisplayName("شرح شکوائيه")]
        public string? PetitionDescription { get; set; }



        [System.ComponentModel.DisplayName("مدارک و مستندات")]
        public string? PetitionReasons { get; set; }



        [System.ComponentModel.DisplayName("موضوع شکايت")]
        public string? PetitionSubject { get; set; }



        [System.ComponentModel.DisplayName("علت رد/نقص شکوائيه")]
        public string? RejectReasonText { get; set; }



        [System.ComponentModel.DisplayName("نام خانوادگي گزارش دهنده در گزارش مردمي")]
        public string? ReporterFamily { get; set; }



        [System.ComponentModel.DisplayName("تلفن همراه گزارش دهنده در گزارش مردمي")]
        public string? ReporterMobilNumber { get; set; }



        [System.ComponentModel.DisplayName("نام گزارش دهنده در گزارش مردمي")]
        public string? ReporterName { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("پیوست مدارک مکانیزه در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.Attachment.GAttachmentContract>? TheGAttachmentContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("مکان جغرافيايي در سرویس")]
        public Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract? TheGeoLocationContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شخص شکوائیه/گزارش مردمی در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenPersonContract>? ThePGravamenPersonContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تخلفات شکوائیه/گزارش مردمی در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.Gravamen.PGravamenViolationContract>? ThePGravamenViolationContractList { get; set; }



    }
}
