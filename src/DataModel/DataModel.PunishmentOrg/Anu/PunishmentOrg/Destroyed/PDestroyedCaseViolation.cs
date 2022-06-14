

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedCaseViolationBase : PunishmentOrgEntity<string>
    {

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PCASEVIOLATIONID")]
		public virtual Anu.PunishmentOrg.Case.PCaseViolation? ThePCaseViolation { get; set; }

		[ForeignKey("PDESTROYEDCASEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

    }
    [Table("PDESTROYEDCASEVIOLATION")]
    public partial class PDestroyedCaseViolation : PDestroyedCaseViolationBase { }

    }


