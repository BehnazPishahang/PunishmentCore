
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("اشخاص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرويس")]
    public class PChaseLicenseReqSuspect
    {
        public PChaseLicenseReqSuspect()
        {
            this.ThePChaseLicenseReqSuspectTypList = new List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqSuspectTyp>(); 
        }
            
            [System.ComponentModel.DisplayName("نشاني")]
            public string Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد")]
            public string BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره شناسنامه")]
            public string IdentityNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
            public string MobilNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
            public string Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي")]
            public string NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مليت")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUNationality Nationality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره گذرنامه")]
            public string PassportNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن ثابت")]
            public string PhoneNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سمت")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PSuspectPostType PostType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کشور تابعيت شخص غيرايراني")]
            public Anu.PunishmentOrg.ServiceContract.PBBillGeoLocation TheNonIranianCitizenship { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
            public Anu.PunishmentOrg.ServiceContract.PChaseLicenseReq ThePChaseLicenseReq { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز شخص مورد تعقيب درخواست مجوز تعقيب/بازرسي")]
            public List<Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqSuspectTyp> ThePChaseLicenseReqSuspectTypList { get; set ;} 
            

    }
    }
