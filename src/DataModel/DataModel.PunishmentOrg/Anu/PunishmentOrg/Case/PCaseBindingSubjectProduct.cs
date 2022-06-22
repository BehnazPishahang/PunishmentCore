

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseBindingSubjectProductBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEBINDINGSUBJECTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseBindingSubject? ThePCaseBindingSubject { get; set; }

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

    }
    [Table("PCASEBINDINGSUBJECTPRODUCT")]
    public partial class PCaseBindingSubjectProduct : PCaseBindingSubjectProductBase { }

    }


