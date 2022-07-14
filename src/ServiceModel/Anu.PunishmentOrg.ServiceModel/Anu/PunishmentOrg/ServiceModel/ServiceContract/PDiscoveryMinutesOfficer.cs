
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("مامورين کشف صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesOfficer
    {
        public PDiscoveryMinutesOfficer()
        {
        }
            
            [System.ComponentModel.DisplayName("درجه")]
            public string? Degree { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن درجه")]
            public Anu.PunishmentOrg.Enumerations.DegreeOfficer DegreeRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("واحد (يگان) کشف")]
            public string? DiscoveryUnit { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string? Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string? FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد بازرسي")]
            public string? InspectionCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کد بازرسي")]
            public Anu.PunishmentOrg.Enumerations.InspectionCodeOfficer InspectionCodeRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي")]
            public string? NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پرسنلي")]
            public string? PersonelNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام دستگاه")]
            public string? SystemName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
