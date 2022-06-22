

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PPrisonerBindingSubjectBase : PunishmentOrgEntity<string>
    {

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PPRISONERID")]
		public virtual Anu.PunishmentOrg.Execution.PPrisoner? ThePPrisoner { get; set; }

    }
    [Table("PPRISONERBINDINGSUBJECT")]
    public partial class PPrisonerBindingSubject : PPrisonerBindingSubjectBase { }

    }


