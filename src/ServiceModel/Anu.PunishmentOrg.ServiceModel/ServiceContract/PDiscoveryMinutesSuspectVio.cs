
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("اتهامات مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesSuspectVio
    {
        public PDiscoveryMinutesSuspectVio()
        {
        }
            
            
            [System.ComponentModel.DisplayName("شيوه ارتکاب تخلف")]
            public Anu.PunishmentOrg.Enumerations.OffenderInvolvedType OffenderInvolvedType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
            public PBViolationType ThePBViolationType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مظنونين صورتجلسه/گزارش کشف قاچاق در سرويس")]
            public PDiscoveryMinutesSuspect ThePDiscoveryMinutesSuspect { get; set ;} 
            

    }
    }
