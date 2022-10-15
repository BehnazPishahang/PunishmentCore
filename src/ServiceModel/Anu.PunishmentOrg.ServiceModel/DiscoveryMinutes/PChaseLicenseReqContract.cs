
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
    public class PChaseLicenseReqContract
    {
        public PChaseLicenseReqContract()
        {
        ThePChaseLicenseReqCrimContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqCrimContract>();

        ThePChaseLicenseReqDocContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqDocContract>();

        ThePChaseLicenseReqPlacesContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqPlacesContract>();

        ThePChaseLicenseReqSuspectContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqSuspectContract>();

        ThePChaseLicenseReqTypeContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqTypeContract>();

        ThePChaseLicenseReqUnitContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqUnitContract>();

        ThePChaseLicenseReqVehicleContractList = new List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqVehicleContract>();

        }
            
            [System.ComponentModel.DisplayName("کد شهرستان درخواست کننده")]
        public string? ApplicantOrgCityId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه دستگاه درخواست کننده")]
        public string? ApplicantOrgId { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد استان درخواست کننده")]
        public string? ApplicantOrgProvinceId { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن درخواست")]
        public string? ChaseLicenseRequestText { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه تعقيب/بازرسي")]
        public Anu.PunishmentOrg.Enumerations.PChaseResult? ChaseResult { get; set; }

            
            
            [System.ComponentModel.DisplayName("موضوع مجوز")]
        public string? ChaseTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح جرم")]
        public string? CrimesANDViolationsSeen { get; set; }

            
            
            [System.ComponentModel.DisplayName("فرایند وقوع تخلف")]
        public string? Description { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName(" رديف")]
        public string? Id { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد واحد قضايي/تعزيرات صادرکننده مجوز")]
        public string? InstitutionCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نهاد صادر کننده مجوز")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference? InstitutionExporter { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان نهاد صادرکننده مجوز")]
        public string? InstitutionTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ نامه دستور نهاد صادر کننده مجوز")]
        public string? LetterRequestDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه دستور نهاد صادر کننده مجوز")]
        public string? LetterRequestNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن دستور نهاد صادر کننده مجوز")]
        public string? LicensorRequestText { get; set; }

            
            
            [System.ComponentModel.DisplayName("نظر مقام ذيصلاح در مورد مدت زمان اعتبار مجوز از تاريخ تاييد آن توسط مقام ذيصلاح بر حسب روز")]
        public long? LicensorValidityDays { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مدرک")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("گزارش ضابط به نهاد صادرکننده مجوز در صورت عدم کشف قاچاق/تخلف")]
        public string? NonDiscoveryRepText { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان دريافت پاسخ نهاد صادر کننده مجوز")]
        public string? ReceiveDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد شهرستان مخاطب")]
        public string? ReceiverOrgCityId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه دستگاه مخاطب")]
        public string? ReceiverOrgId { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد استان مخاطب")]
        public string? ReceiverOrgProvinceId { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان ارسال گزارش به نهاد صادر کننده مجوز")]
        public string? RepSendDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("گزارش ضابط به نهاد صادرکننده مجوز بابت درخواست شفاهي")]
        public string? RepText { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ درخواست/شفاهي")]
        public string? ReqDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساعت درخواست/شفاهي")]
        public string? ReqTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان ارسال به نهاد صادر کننده مجوز")]
        public string? SendDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("رویه قاچاق")]
        public string? SmugglingProcedure { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع قاچاق")]
        public Anu.PunishmentOrg.Enumerations.SmugglingType? SmugglingType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرعي")]
        public long? SubNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شهر/دهستان مربوطه")]
        public Anu.BaseInfo.ServiceModel.GeoInfo.GeoLocationContract? TheGeoLocation { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد قضايي صادر کننده مجوز")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheJudicialUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت اشياء")]
        public Anu.BaseInfo.ServiceModel.SystemObject.ObjectStateContract? TheObjectState { get; set; }

            
            
            [System.ComponentModel.DisplayName("کاشف ضابط متقاضي")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? ThePBExchangeUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تخلفات درخواست های 4گانه در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqCrimContract>? ThePChaseLicenseReqCrimContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سند مورد بازرسي درخواست مجوز تعقيب بازرسي در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqDocContract>? ThePChaseLicenseReqDocContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("محل هاي، درخواست 4گانه در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqPlacesContract>? ThePChaseLicenseReqPlacesContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص، درخواست 4گانه در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqSuspectContract>? ThePChaseLicenseReqSuspectContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("موضوع درخواست، درخواست های 4گانه در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqTypeContract>? ThePChaseLicenseReqTypeContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان داراي دسترسي به درخواست مجوز تعقيب/بازرسي و پاسخ آن در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqUnitContract>? ThePChaseLicenseReqUnitContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وسيله نقليه، درخواست 4گانه در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqVehicleContract>? ThePChaseLicenseReqVehicleContractList { get; set; }

            
            
            [System.ComponentModel.DisplayName("درخواست قبلي مرتبط با درخواست جاري")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePrvReq { get; set; }

            
            
            [System.ComponentModel.DisplayName("شعبه اي که صورتجلسه جهت رسيدگي به آن ارجاع شده")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract? TheReferUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد تعزيراتي اعطا کننده مجوز")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.UnitContract? TheUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول مقام صادر کننده مجوز")]
        public string? UnwriteReqDescByLicensor { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول ضابط")]
        public string? UnwriteReqDescByOfficer { get; set; }

            
            
            [System.ComponentModel.DisplayName("خلاصه نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول مقام صادر کننده مجوز")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? UnwriteReqResultByLicensor { get; set; }

            
            
            [System.ComponentModel.DisplayName("خلاصه نظر مقام صادر کننده مجوز شفاهي در مورد درخواست صدور مجوز شفاهي از قول ضابط")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? UnwriteReqResultByOfficer { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي درخواست کننده شفاهي مجوز")]
        public string? UnwrittenReqFamily { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام درخواست کننده شفاهي مجوز")]
        public string? UnwrittenReqName { get; set; }

            
            
            [System.ComponentModel.DisplayName("پيشنهاد ضابط براي مدت زمان اعتبار مجوز از تاريخ تاييد آن توسط مقام ذيصلاح بر حسب روز")]
        public long? ValidityDays { get; set; }

            
            
            [System.ComponentModel.DisplayName("کتبي مسبوق به شفاهي/کتبي")]
        public Anu.PunishmentOrg.Enumerations.WrittenOrOral? WrittenOrOral { get; set; }

            

    }
    }
