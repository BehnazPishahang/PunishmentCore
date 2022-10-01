
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("اداره کننده/صاحب پروانه در سرويس")]
    public class PInspectionReportDirectors
    {
        public PInspectionReportDirectors()
        {
            this.ThePInspectionReportPostList = new List<PInspectionReportPost>(); 
        }
            
            [System.ComponentModel.DisplayName("نشاني شخص حقيقي/حقوقي")]
            public string? Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نشاني شخص حقيقي/حقوقي")]
            public string? AddressRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد شخص حقيقي")]
            public string? BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تاريخ تولد شخص حقيقي")]
            public Anu.PunishmentOrg.Enumerations.Refuse BirthDateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("توضيحات ")]
            public string? Description { get; set ;} 
            
            
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
            public Anu.BaseInfo.Enumerations.LNationality Nationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن  تابعيت شخص حقيقي/حقوقي")]
            public Anu.PunishmentOrg.Enumerations.Refuse NationalityRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير سمت")]
            public string? OtherPost { get; set ;} 
            
            
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
            public PBBillGeoLocation ThePBBillGeoLocation { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سمت اداره کننده / صاحب پروانه در سرويس")]
            public List<PInspectionReportPost> ThePInspectionReportPostList { get; set ;} 
            

    }
    }
