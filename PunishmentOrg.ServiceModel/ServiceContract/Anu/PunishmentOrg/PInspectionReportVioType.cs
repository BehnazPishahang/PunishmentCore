
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("انواع تخف گزارش بازرسي در سرويس")]
    public class PInspectionReportVioType
    {
        public PInspectionReportVioType()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع تخلف گزارش بازرسي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBInspectionViolationType ThePBInspectionViolationType { get; set ;} 
            

    }
    }
