
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("بازرسان گزارش بازرسي در سرويس")]
    public class PInspectionReportInspector
    {
        public PInspectionReportInspector()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string Family { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد")]
            public string InspectorCode { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت")]
            public Anu.Enumerations.PunishmentOrg.PUInspectorPost InspectorPost { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
            public string Name { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد ملي")]
            public string NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام دستگاه")]
            public string SystemName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس گزارش بازرسي")]
            public Anu.PunishmentOrg.ServiceContract.PInspectionReport ThePInspectionReport { get; set ;} 
            

    }
    }
