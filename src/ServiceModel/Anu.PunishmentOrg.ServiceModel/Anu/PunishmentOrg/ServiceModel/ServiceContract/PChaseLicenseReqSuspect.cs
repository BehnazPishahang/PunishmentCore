
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("اشخاص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرويس")]
    public class PChaseLicenseReqSuspect
    {
        public PChaseLicenseReqSuspect()
        {
            this.ThePChaseLicenseReqSuspectTypList = new List<PChaseLicenseReqSuspectTyp>(); 
        }
            
            [System.ComponentModel.DisplayName("نشاني")]
            public string? Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد")]
            public string? BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string? Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string? FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه")]
            public string? IdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
            public string? MobilNumber { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي")]
            public string? NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مليت")]
            public Anu.PunishmentOrg.Enumerations.PUNationality Nationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه")]
            public string? PassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن ثابت")]
            public string? PhoneNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سمت")]
            public Anu.PunishmentOrg.Enumerations.PSuspectPostType PostType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کشور تابعيت شخص غيرايراني")]
            public PBBillGeoLocation TheNonIranianCitizenship { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
            public PChaseLicenseReq ThePChaseLicenseReq { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع مجوز شخص مورد تعقيب درخواست مجوز تعقيب/بازرسي")]
            public List<PChaseLicenseReqSuspectTyp> ThePChaseLicenseReqSuspectTypList { get; set ;} 
            

    }
    }
