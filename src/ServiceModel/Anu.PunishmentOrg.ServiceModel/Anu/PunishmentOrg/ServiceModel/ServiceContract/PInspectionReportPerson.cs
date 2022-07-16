
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("شاکي هاي گزارش بازرسي در سرويس")]
    public class PInspectionReportPerson
    {
        public PInspectionReportPerson()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني")]
            public string? Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ تولد/ثبت")]
            public string? BirthDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string? Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string? FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تلفن همراه")]
            public string? MobilNumber { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي")]
            public string? NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تابعيت")]
            public Anu.PunishmentOrg.Enumerations.PUNationality Nationality { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع شخص")]
            public Anu.BaseInfo.Enumerations.PersonType PersonType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد پستي")]
            public string? PostCode { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("جنسيت")]
            public Anu.BaseInfo.Enumerations.SexType Sex { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس گزارش بازرسي")]
            public PInspectionReport ThePInspectionReport { get; set ;} 
            

    }
    }
