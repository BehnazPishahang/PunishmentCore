
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
    public class PBViolationType
    {
        public PBViolationType()
        {
            this.ThePBViolationTypeInspectionList = new List<Anu.PunishmentOrg.ServiceContract.PBViolationTypeInspection>(); 
            this.ThePDiscoveryMinutesSuspectVioList = new List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectVio>(); 
        }
            
            [System.ComponentModel.DisplayName("نوع موضوع تخلف")]
            public Anu.Enumerations.PunishmentOrg.PUViolationType CaseSubject { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مستند قانوني")]
            public string LawDocument { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع تخلف از نظر کالا/ارز/خدمات")]
            public Anu.Enumerations.PunishmentOrg.PUProductCurrency ProductCurrency { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع موضوع")]
            public Anu.Enumerations.PunishmentOrg.PUSubjectTYpe SubjectType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تخلف هاي معادل يک نوع تخلف گزارش بازرسي در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PBViolationTypeInspection> ThePBViolationTypeInspectionList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspectVio> ThePDiscoveryMinutesSuspectVioList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Title { get; set ;} 
            

    }
    }
