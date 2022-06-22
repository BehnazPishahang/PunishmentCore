

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PInstallmentBindingSubjectBase : PunishmentOrgEntity<string>
    {

		[Column("OLDCASEBINDINGIDS")]
		public virtual string? OldCaseBindingIDs { get; set; }

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PINSTALLMENTID")]
		public virtual Anu.PunishmentOrg.Execution.PInstallment? ThePInstallment { get; set; }

    }
    [Table("PINSTALLMENTBINDINGSUBJECT")]
    public partial class PInstallmentBindingSubject : PInstallmentBindingSubjectBase { }

    }


