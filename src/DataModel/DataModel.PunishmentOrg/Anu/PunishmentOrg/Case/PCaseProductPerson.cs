

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseProductPersonBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PCASEPRODUCTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseProduct? ThePCaseProduct { get; set; }

    }
    [Table("PCASEPRODUCTPERSON")]
    public partial class PCaseProductPerson : PCaseProductPersonBase { }

    }


