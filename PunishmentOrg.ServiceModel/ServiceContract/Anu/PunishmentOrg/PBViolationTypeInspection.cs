
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("تخلف هاي معادل يک نوع تخلف گزارش بازرسي در سرويس")]
    public class PBViolationTypeInspection
    {
        public PBViolationTypeInspection()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع تخلف گزارش بازرسي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBInspectionViolationType ThePBInspectionViolationType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBViolationType ThePBViolationType { get; set ;} 
            

    }
    }
