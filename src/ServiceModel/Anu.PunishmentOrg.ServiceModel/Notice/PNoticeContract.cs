
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("ابلاغنامه در سرویس")]
    public class PNoticeContract
    {
        public PNoticeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نوع نشاني")]
        public Anu.BaseInfo.Enumerations.AddressType? AddressType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مامور ابلاغ")]
        public string? AgentFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام مامور ابلاغ")]
        public string? AgentName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده ها/فرعي هاي مربوطه")]
        public string? CasesNoSubno { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي تحويل گيرنده ابلاغ")]
        public string? DeliverFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام تحويل گيرنده ابلاغ")]
        public string? DeliverName { get; set; }

            
            
            [System.ComponentModel.DisplayName("سمت تحويل گيرنده ابلاغ")]
        public string? DeliverPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن ابلاغيه")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن قابل رايانامه شدن ابلاغ")]
        public string? EMailText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه ابلاغ")]
        public Anu.BaseInfo.Enumerations.HowNotified? HowNotified { get; set; }

            
            
            [System.ComponentModel.DisplayName("مهلت حضور")]
        public long? InputStatistic { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا ابلاغيه چاپ شده")]
        public Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

            
            
            [System.ComponentModel.DisplayName("آيا ابلاغ بر روي سايت سازمان توسط ابلاغ شونده رويت شده است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsViewedOnSite { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("گواهي ابلاغ")]
        public string? NoticeCertification { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ ابلاغ")]
        public string? NoticeDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه ابلاغ")]
        public Anu.BaseInfo.Enumerations.NoticeFinalResult? NoticeFinalResult { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن دستور ابلاغ")]
        public string? NoticeOrder { get; set; }

            
            
            [System.ComponentModel.DisplayName("نشاني ابلاغ شونده")]
        public string? NoticePersonAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("آدرس پست الکترونيکي ابلاغ شونده")]
        public string? NoticePersonEMailAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي ابلاغ شونده")]
        public string? NoticePersonFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر ابلاغ شونده")]
        public string? NoticePersonFatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره همراه ابلاغ شونده جهت ارسال پيام کوتاه")]
        public string? NoticePersonMobileNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام ابلاغ شونده")]
        public string? NoticePersonName { get; set; }

            
            
            [System.ComponentModel.DisplayName("صندوق پستي ابلاغ شونده")]
        public string? NoticePersonPostBox { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي ابلاغ شونده")]
        public string? NoticePersonPostCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت ابلاغ شونده")]
        public Anu.BaseInfo.Enumerations.SexType? NoticePersonSex { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ حضور")]
        public string? PresenceDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت حضور")]
        public string? PresenceTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ چاپ ابلاغ")]
        public string? PrintNoticeDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("هامش")]
        public string? SideNote { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن قابل پيامک شدن ابلاغ")]
        public string? SMSText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("پرونده در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.Case.PCaseContract? ThePCaseContract { get; set; }

            

    }
    }
