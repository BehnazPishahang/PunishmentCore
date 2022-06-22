
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSuspect
    {
        public PDiscoveryMinutesSuspect()
        {
            this.ThePDiscoveryMinutesSuspectHstList = new List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectHst>(); 
            this.ThePDiscoveryMinutesSuspectPostList = new List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectPost>(); 
            this.ThePDiscoveryMinutesSuspectVioList = new List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectVio>(); 
        }
            
            [System.ComponentModel.DisplayName("نشاني شخص حقيقي/حقوقي")]
            public string Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نشاني شخص حقيقي/حقوقي")]
            public string AddressRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد شخص حقيقي")]
            public string BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تاريخ تولد شخص حقيقي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.Refuse BirthDateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("توضيحات سمت")]
            public string Description { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دليل استنکاف مظنون از امضاء صورتجلسه")]
            public string DisclaimerReason { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي شخص حقيقي")]
            public string Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر شخص حقيقي")]
            public string FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام پدر شخص حقيقي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.Refuse FatherNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام و نام خانوادگي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.Refuse FullNameRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه شخص حقيقي")]
            public string IdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره شناسنامه")]
            public string IdentityNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا مظنون از امضاء صورتجلسه استنکاف کرده؟")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo IsDisclaimer { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا سوابق اتهامي قبلي شخص از طريق پايگاه داده محکومين جستجو شده؟")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo IsSearchHistory { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه شخص حقيقي")]
            public string MobilNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تلفن همراه شخص حقيقي")]
            public string MobilNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام شخص حقيقي/حقوقي")]
            public string Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي شخص حقيقي ايراني/کد ملي شخص حقوقي ايراني")]
            public string NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره ملي شخص حقيقي ايراني/کد ملي شخص حقوقي ايراني")]
            public DataModel.Anu.Enumerations.PunishmentOrg.Refuse NationalCodeRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت تابعيت شخص حقيقي/حقوقي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUNationality Nationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن  تابعيت شخص حقيقي/حقوقي")]
            public DataModel.Anu.Enumerations.PunishmentOrg.Refuse NationalityRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد سوابق يافت شده براي شخص")]
            public long? NumOfHistory { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه شخص حقيقي غيرايراني")]
            public string PassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره گذرنامه شخص حقيقي غيرايراني")]
            public string PassportNoRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص")]
            public DataModel.BaseInfo.Anu.Enumerations.PersonType PersonType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن ثابت شخص حقيقي/حقوقي")]
            public string PhoneNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تلفن ثابت شخص حقيقي/حقوقي")]
            public string PhoneNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBBillGeoLocation TheNonIranianCitizenship { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سوابق مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectHst> ThePDiscoveryMinutesSuspectHstList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت مظنونين در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectPost> ThePDiscoveryMinutesSuspectPostList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectVio> ThePDiscoveryMinutesSuspectVioList { get; set ;} 
            

    }
    }
