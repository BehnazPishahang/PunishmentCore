
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSuspect
    {
        public PDiscoveryMinutesSuspect()
        {
            this.ThePDiscoveryMinutesSuspectHstList = new List<PDiscoveryMinutesSuspectHst>(); 
            this.ThePDiscoveryMinutesSuspectPostList = new List<PDiscoveryMinutesSuspectPost>(); 
            this.ThePDiscoveryMinutesSuspectVioList = new List<PDiscoveryMinutesSuspectVio>(); 
        }
            
            [System.ComponentModel.DisplayName("نشاني شخص حقيقي/حقوقي")]
            public string? Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نشاني شخص حقيقي/حقوقي")]
            public string? AddressRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد شخص حقيقي")]
            public string? BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تاريخ تولد شخص حقيقي")]
            public Anu.PunishmentOrg.Enumerations.Refuse BirthDateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("توضيحات سمت")]
            public string? Description { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دليل استنکاف مظنون از امضاء صورتجلسه")]
            public string? DisclaimerReason { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي شخص حقيقي")]
            public string? Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر شخص حقيقي")]
            public string? FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام پدر شخص حقيقي")]
            public Anu.PunishmentOrg.Enumerations.Refuse FatherNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي")]
            public Anu.PunishmentOrg.Enumerations.Refuse FullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه شخص حقيقي")]
            public string? IdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره شناسنامه")]
            public string? IdentityNumberRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("آيا مظنون از امضاء صورتجلسه استنکاف کرده؟")]
            public Anu.BaseInfo.Enumerations.YesNo IsDisclaimer { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا سوابق اتهامي قبلي شخص از طريق پايگاه داده محکومين جستجو شده؟")]
            public Anu.BaseInfo.Enumerations.YesNo IsSearchHistory { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه شخص حقيقي")]
            public string? MobilNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تلفن همراه شخص حقيقي")]
            public string? MobilNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام شخص حقيقي/حقوقي")]
            public string? Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي شخص حقيقي ايراني/کد ملي شخص حقوقي ايراني")]
            public string? NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره ملي شخص حقيقي ايراني/کد ملي شخص حقوقي ايراني")]
            public Anu.PunishmentOrg.Enumerations.Refuse NationalCodeRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت تابعيت شخص حقيقي/حقوقي")]
            public Anu.PunishmentOrg.Enumerations.PUNationality Nationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن  تابعيت شخص حقيقي/حقوقي")]
            public Anu.PunishmentOrg.Enumerations.Refuse NationalityRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد سوابق يافت شده براي شخص")]
            public long? NumOfHistory { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه شخص حقيقي غيرايراني")]
            public string? PassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره گذرنامه شخص حقيقي غيرايراني")]
            public string? PassportNoRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع شخص")]
            public Anu.BaseInfo.Enumerations.PersonType PersonType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن ثابت شخص حقيقي/حقوقي")]
            public string? PhoneNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تلفن ثابت شخص حقيقي/حقوقي")]
            public string? PhoneNumberRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
            public PBBillGeoLocation TheNonIranianCitizenship { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سوابق مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesSuspectHst> ThePDiscoveryMinutesSuspectHstList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سمت مظنونين در سرويس")]
            public List<PDiscoveryMinutesSuspectPost> ThePDiscoveryMinutesSuspectPostList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesSuspectVio> ThePDiscoveryMinutesSuspectVioList { get; set ;} 
            

    }
    }
