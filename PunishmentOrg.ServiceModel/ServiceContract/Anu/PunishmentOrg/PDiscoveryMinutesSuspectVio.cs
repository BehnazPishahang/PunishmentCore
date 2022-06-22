
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSuspectVio
    {
        public PDiscoveryMinutesSuspectVio()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شيوه ارتکاب تخلف")]
            public DataModel.Anu.Enumerations.PunishmentOrg.OffenderInvolvedType OffenderInvolvedType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBViolationType ThePBViolationType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutesSuspect ThePDiscoveryMinutesSuspect { get; set ;} 
            

    }
    }
