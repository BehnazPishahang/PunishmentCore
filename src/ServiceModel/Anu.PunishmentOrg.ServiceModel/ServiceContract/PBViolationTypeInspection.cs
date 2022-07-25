
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("تخلف هاي معادل يک نوع تخلف گزارش بازرسي در سرويس")]
    public class PBViolationTypeInspection
    {
        public PBViolationTypeInspection()
        {
        }
            
            
            [System.ComponentModel.DisplayName("نوع تخلف گزارش بازرسي در سرويس")]
            public PBInspectionViolationType ThePBInspectionViolationType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
            public PBViolationType ThePBViolationType { get; set ;} 
            

    }
    }
