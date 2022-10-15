
using Anu.PunishmentOrg.ServiceModel.ServiceContract;

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

            ThePGravamenNoticeHstContractList = new List<PGravamenNoticeHstContract>();

            ThePGravamenRejectOrDefectRSContractList = new List<PGravamenRejectOrDefectRSContract>();
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



        [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
        public ObjectState TheObjectStateContract { get; set; }



        [System.ComponentModel.DisplayName("پرونده در سرویس")]
        public PCase ThePCaseContract { get; set; }



        [System.ComponentModel.DisplayName("تاریخچه ابلاغیه های شکوائیه در سرویس")]
        public List<PGravamenNoticeHstContract> ThePGravamenNoticeHstContractList { get; set; }



        [System.ComponentModel.DisplayName("دلایل رد شکوائیه در سرویس")]
        public List<PGravamenRejectOrDefectRSContract> ThePGravamenRejectOrDefectRSContractList { get; set; }



        [System.ComponentModel.DisplayName("واحد دریافت شکوائیه در سرویس")]
        public Unit TheReceiveUnitContract { get; set; }



        [System.ComponentModel.DisplayName("واحد ارجاع شکوائیه در سرویس")]
        public Unit TheReferUnitContract { get; set; }

    }
    }
