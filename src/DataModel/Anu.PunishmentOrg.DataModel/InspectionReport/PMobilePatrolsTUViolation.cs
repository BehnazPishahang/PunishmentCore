using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.InspectionReport
{
    public abstract class PMobilePatrolsTUViolationBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PMOBILEPATROLSTRADEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.InspectionReport.PMobilePatrolsTradeUnit? ThePMobilePatrolsTradeUnit { get; set; }

        }

    [Table("PMOBILEPATROLSTUVIOLATION")]
    public partial class PMobilePatrolsTUViolation : PMobilePatrolsTUViolationBase
    {
    }
    }