

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PMechanizedLetterPersonBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

    }
    [Table("PMECHANIZEDLETTERPERSON")]
    public partial class PMechanizedLetterPerson : PMechanizedLetterPersonBase { }

    }


