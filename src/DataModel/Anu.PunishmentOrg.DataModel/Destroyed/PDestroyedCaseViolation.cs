using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedCaseViolationBase : PunishmentOrgEntity<string>
    {

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [ForeignKey("PCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseViolation? ThePCaseViolation { get; set; }

        [ForeignKey("PDESTROYEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

        }

    [Table("PDESTROYEDCASEVIOLATION")]
    public partial class PDestroyedCaseViolation : PDestroyedCaseViolationBase
    {
    }
    }