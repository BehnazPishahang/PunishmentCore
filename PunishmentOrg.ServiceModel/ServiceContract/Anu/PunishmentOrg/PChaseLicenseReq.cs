
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
    public class PChaseLicenseReq
    {
        public PChaseLicenseReq()
        {
            this.ThePChaseLicenseReqDocList = new List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqDoc>(); 
            this.ThePChaseLicenseReqPlacesList = new List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqPlaces>(); 
            this.ThePChaseLicenseReqSuspectList = new List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqSuspect>(); 
            this.ThePChaseLicenseReqVehicleList = new List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqVehicle>(); 
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن درخواست")]
            public string ChaseLicenseRequestText { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نتيجه تعقيب/بازرسي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PChaseResult ChaseResult { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("موضوع مجوز")]
            public string ChaseTitle { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string CreateDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شرح جرم")]
            public string CrimesANDViolationsSeen { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد واحد قضايي/تعزيرات صادرکننده مجوز")]
            public string InstitutionCode { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نهاد صادر کننده مجوز")]
            public DataModel.Anu.Enumerations.PunishmentOrg.DiscoveryMinutesCompetenceReference InstitutionExporter { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان نهاد صادرکننده مجوز")]
            public string InstitutionTitle { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ نامه دستور نهاد صادر کننده مجوز")]
            public string LetterRequestDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره نامه دستور نهاد صادر کننده مجوز")]
            public string LetterRequestNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("متن دستور نهاد صادر کننده مجوز")]
            public string LicensorRequestText { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نظر مقام ذيصلاح در مورد مدت زمان اعتبار مجوز از تاريخ تاييد آن توسط مقام ذيصلاح بر حسب روز")]
            public long? LicensorValidityDays { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("گزارش ضابط به نهاد صادرکننده مجوز در صورت عدم کشف قاچاق/تخلف")]
            public string NonDiscoveryRepText { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("زمان دريافت پاسخ نهاد صادر کننده مجوز")]
            public string ReceiveDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("زمان ارسال گزارش به نهاد صادر کننده مجوز")]
            public string RepSendDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("گزارش ضابط به نهاد صادرکننده مجوز بابت درخواست شفاهي")]
            public string RepText { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ درخواست/شفاهي")]
            public string ReqDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساعت درخواست/شفاهي")]
            public string ReqTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("زمان ارسال به نهاد صادر کننده مجوز")]
            public string SendDateTime { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرعي")]
            public long? SubNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شهر/دهستان مربوطه")]
            public Anu.PunishmentOrg.ServiceContract.PBBillGeoLocation ThePBBillGeoLocation { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کاشف ضابط متقاضي")]
            public Anu.PunishmentOrg.ServiceContract.PBExchangeUnit ThePBExchangeUnit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سند مورد بازرسي درخواست مجوز تعقيب بازرسي")]
            public List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqDoc> ThePChaseLicenseReqDocList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("محل هاي مورد بازرسي درخواست مجوز تعقيب/بازرسي در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqPlaces> ThePChaseLicenseReqPlacesList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqSuspect> ThePChaseLicenseReqSuspectList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وسيله نقليه مورد بازرسي درخواست مجوز تعقيب بازرسي در سرويس در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqVehicle> ThePChaseLicenseReqVehicleList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string UniqueNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شرح نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول مقام صادر کننده مجوز")]
            public string UnwriteReqDescByLicensor { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شرح نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول ضابط")]
            public string UnwriteReqDescByOfficer { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("خلاصه نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول مقام صادر کننده مجوز")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion UnwriteReqResultByLicensor { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("خلاصه نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول ضابط")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion UnwriteReqResultByOfficer { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي درخواست کننده شفاهي مجوز")]
            public string UnwrittenReqFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام درخواست کننده شفاهي مجوز")]
            public string UnwrittenReqName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string UserName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پيشنهاد ضابط براي مدت زمان اعتبار مجوز از تاريخ تاييد آن توسط مقام ذيصلاح بر حسب روز")]
            public long? ValidityDays { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کتبي مسبوق به شفاهي/کتبي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.WrittenOrOral WrittenOrOral { get; set ;} 
            

    }
    }
