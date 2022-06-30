
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("انواع تخف گزارش بازرسي در سرويس")]
    public class PInspectionReportVioType
    {
        public PInspectionReportVioType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع تخلف گزارش بازرسي در سرويس")]
            public PBInspectionViolationType ThePBInspectionViolationType { get; set ;} 
            

    }
    }
