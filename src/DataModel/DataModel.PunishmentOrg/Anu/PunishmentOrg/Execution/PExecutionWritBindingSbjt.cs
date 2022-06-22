

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PExecutionWritBindingSbjtBase : PunishmentOrgEntity<string>
    {

		[Column("DEBTREDUCTIONVALUE")]
		public virtual long? DebtReductionValue { get; set; }

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PEXECUTIONWRITID")]
		public virtual Anu.PunishmentOrg.Execution.PExecutionWrit? ThePExecutionWrit { get; set; }

    }
    [Table("PEXECUTIONWRITBINDINGSBJT")]
    public partial class PExecutionWritBindingSbjt : PExecutionWritBindingSbjtBase { }

    }


