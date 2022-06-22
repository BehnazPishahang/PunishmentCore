

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseBindingSubjectTripleBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PCASETRIPLEID")]
		public virtual Anu.PunishmentOrg.Case.PCaseTriple? ThePCaseTriple { get; set; }

    }
    [Table("PCASEBINDINGSUBJECTTRIPLE")]
    public partial class PCaseBindingSubjectTriple : PCaseBindingSubjectTripleBase { }

    }


