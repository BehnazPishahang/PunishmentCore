using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PInspectionReportVioTypeBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBINSPECTIONVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBInspectionViolationType? ThePBInspectionViolationType { get; set; }

        [ForeignKey("PINSPECTIONREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PInspectionReportViolation? ThePInspectionReportViolation { get; set; }

        }

    [Table("PINSPECTIONREPORTVIOTYPE")]
    public partial class PInspectionReportVioType : PInspectionReportVioTypeBase
    {
    }
    }