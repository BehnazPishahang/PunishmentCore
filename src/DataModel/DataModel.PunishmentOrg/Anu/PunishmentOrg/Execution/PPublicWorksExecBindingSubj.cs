

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Execution
{
    public abstract class PPublicWorksExecBindingSubjBase : PunishmentOrgEntity<string>
    {

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PPUBLICWORKSEXECID")]
		public virtual Anu.PunishmentOrg.Execution.PPublicWorksExec? ThePPublicWorksExec { get; set; }

    }
    [Table("PPUBLICWORKSEXECBINDINGSUBJ")]
    public partial class PPublicWorksExecBindingSubj : PPublicWorksExecBindingSubjBase { }

    }


