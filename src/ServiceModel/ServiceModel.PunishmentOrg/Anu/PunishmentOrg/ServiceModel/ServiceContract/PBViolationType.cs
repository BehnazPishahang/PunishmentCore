
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
    public class PBViolationType
    {
        public PBViolationType()
        {
            this.ThePBViolationTypeInspectionList = new List<PBViolationTypeInspection>(); 
            this.ThePDiscoveryMinutesSuspectVioList = new List<PDiscoveryMinutesSuspectVio>(); 
        }
            
            [System.ComponentModel.DisplayName("نوع موضوع تخلف")]
            public Anu.PunishmentOrg.Enumerations.PUViolationType CaseSubject { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مستند قانوني")]
            public string LawDocument { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع تخلف از نظر کالا/ارز/خدمات")]
            public Anu.PunishmentOrg.Enumerations.PUProductCurrency ProductCurrency { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع موضوع")]
            public Anu.PunishmentOrg.Enumerations.PUSubjectTYpe SubjectType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تخلف هاي معادل يک نوع تخلف گزارش بازرسي در سرويس")]
            public List<PBViolationTypeInspection> ThePBViolationTypeInspectionList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<PDiscoveryMinutesSuspectVio> ThePDiscoveryMinutesSuspectVioList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Title { get; set ;} 
            

    }
    }
