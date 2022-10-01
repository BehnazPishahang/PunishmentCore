
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesContract
    {
        public PDiscoveryMinutesContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ ابلاغ موضوع ماده 21")]
        public string? Article21NoticeDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده کالا/ارز")]
        public string? BillNoProductOrDocFound { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده در تعزيرات/دادگاه انقلاب")]
        public string? CaseNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره فرعي پرونده در تعزيرات/دادگاه انقلاب")]
        public long? CaseSubNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مرجع صلاحيت دارجهت رسيدگي به پرونده")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryMinutesCompetenceReference? CompetenceReference { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ کشف")]
        public string? DiscoveryDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مدرک")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryDocType? DiscoveryDocType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره صورتجلسه/گزارش")]
        public string? DiscoveryNO { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد (يگان) کاشف")]
        public string? DiscoveryOfficerUnit { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آدرس محل کشف")]
        public string? DiscoveryPlaceAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("بهره بردار محل کشف")]
        public string? DiscoveryPlaceBeneficiary { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن بهره بردار محل کشف")]
        public string? DiscoveryPlaceBeneficiaryRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه/مجوز محل کشف")]
        public string? DiscoveryPlacelicenseNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("مالک محل کشف")]
        public string? DiscoveryPlaceOwner { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن مالک محل کشف")]
        public string? DiscoveryPlaceOwnerRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره تلفن محل کشف")]
        public string? DiscoveryPlacePhoneNum { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره تلفن محل کشف")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePhoneNum? DiscoveryPlacePhoneNumRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("پلاک محل کشف")]
        public string? DiscoveryPlacePlaque { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن پلاک محل کشف")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePlaque? DiscoveryPlacePlaqueRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد پستي محل کشف")]
        public string? DiscoveryPlacePostalCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کد پستي محل کشف")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryPlacePostalCode? DiscoveryPlacePostalCodeRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام واحد محل کشف")]
        public string? DiscoveryPlaceUnitName { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام واحد محل کشف")]
        public Anu.PunishmentOrg.Enumerations.DiscoveryPlaceUnitName? DiscoveryPlaceUnitNameRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ساعت کشف")]
        public string? DiscoveryTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("ساير انواع محل و مکان کشف")]
        public string? DiscoveryTypeOtherPlace { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره شعبه دادگاه انقلاب که به پرونده رسيدگي ميکند")]
        public long? EnghelabCourtNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شواهد,قرائن و اماراتي مبني بر احتمال وقوع سازمان يافته قاچاق")]
        public string? EvidencePossibility { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره فرم چهار برگی")]
        public string? FourSheetNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت شماره پروانه/مجوز صنفي محل کشف")]
        public Anu.BaseInfo.Enumerations.HaveNoHave? HavePlacelicenseNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شرح چگونگي کشف قاچاق و دستگيري")]
        public string? HowFindArrest { get; set; }

            
            
            [System.ComponentModel.DisplayName("دلايل عدم دسترسي ويا احراز متهم")]
        public string? InaccessAccuseReason { get; set; }

            
            
            [System.ComponentModel.DisplayName("دلايل عدم وجود کالا در جريان کشف و يا از بين رفتن کالا")]
        public string? InaccessProductReason { get; set; }

            
            
            [System.ComponentModel.DisplayName("آدرس استعلام شده با استفاده از کد پستی")]
        public string? InqueryAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالای مکشوفه از مصادیق ماده 25 یا 27 قانون قاچاق میباشد")]
        public Anu.PunishmentOrg.Enumerations.IsArticle25? IsArticle25 { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا کالا به سازمان اموال تملیکی تحویل داده شده است؟")]
        public Anu.PunishmentOrg.Enumerations.IsDeliveryGoodsToOroperty? IsDeliveryGoodsToOroperty { get; set; }

            
            
            [System.ComponentModel.DisplayName("وسايل نقليه دارد؟")]
        public Anu.BaseInfo.Enumerations.HaveAttachment? IsVehicle { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت ثبت محل نگهداري کالا در سامانه جامع انبارها و مراکز نگهداري کالا")]
        public Anu.PunishmentOrg.Enumerations.PURegister? KeepPlaceState { get; set; }

            
            
            [System.ComponentModel.DisplayName("دلايل عدم احراز مالکيت کالا و ارز,وسيله نقليه و محل نگهداري آنها")]
        public string? LackOfOwnershipReason { get; set; }

            
            
            [System.ComponentModel.DisplayName("اطلاع از طريق مخبر")]
        public Anu.BaseInfo.Enumerations.YesNo? NotifyOfAware { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد رهگیری سامانه دیگر سازمان ها")]
        public string? PreviousCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات ارز/کالاي مکشوفه")]
        public string? ProductFoundDesc { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن توضيحات ارز/کالاي مکشوفه")]
        public Anu.PunishmentOrg.Enumerations.ProductFoundDesc? ProductFoundDescRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("موارد مطابق قانون تعيين دليل انتخاب مرجع")]
        public Anu.PunishmentOrg.Enumerations.PReasonChoiceCasesAccordanceWithLaw? ReasonChoiceAccordanceLaw { get; set; }

            
            
            [System.ComponentModel.DisplayName("تعيين دليل انتخاب مرجع")]
        public Anu.PunishmentOrg.Enumerations.PReferenceSelectReason? ReasonChoiceRefrence { get; set; }

            
            
            [System.ComponentModel.DisplayName("شگرد ارتکاب جرم يا تخلف")]
        public string? SmugglingTrick { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع جرم يا تخلف ساير")]
        public string? SmugglingTypeOthers { get; set; }

            
            
            [System.ComponentModel.DisplayName("جزئيات ارتکاب قاچاق همراه با جرايم ديگر")]
        public string? SmugglingWithCrimes { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت وجود مظنون/مظنونان کشف ")]
        public Anu.PunishmentOrg.Enumerations.SuspectState? SuspectState { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مجموع مکشوفه ده ميليون ريال يا کمتر ارزش دارد")]
        public Anu.BaseInfo.Enumerations.YesNo? TotalArtifactsValue { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جمع کل ارزش تخميني ارز/کالاي مکشوفه")]
        public decimal? TotalProductFound { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه سامانه جامع انبارها")]
        public string? TrackingCodeStores { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا شناسه سامانه جامع انبارها با سامانه اموال تملیکی مطابقت دارد یا نه؟")]
        public Anu.PunishmentOrg.Enumerations.TrackingNoInquery? TrackingCodeStoresInquery { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان آخرين راستي آزمايي")]
        public string? VerificationDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نتيجه راستي آزمايي اطلاعات")]
        public string? VerificationResult { get; set; }

            
            
            [System.ComponentModel.DisplayName("دستگاه کاشف")]
        public string? ZoneName { get; set; }

            

    }
    }
