
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع تخلف گزارش بازرسي در سرويس")]
    public class PBInspectionViolationType
    {
        public PBInspectionViolationType()
        {
            this.ThePBViolationTypeInspectionList = new List<PBViolationTypeInspection>(); 
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع موضوع تخلف")]
            public Anu.PunishmentOrg.Enumerations.PUViolationType CaseSubject { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تخلف هاي معادل يک نوع تخلف گزارش بازرسي در سرويس")]
            public List<PBViolationTypeInspection> ThePBViolationTypeInspectionList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Title { get; set ;} 
            

    }
    }
