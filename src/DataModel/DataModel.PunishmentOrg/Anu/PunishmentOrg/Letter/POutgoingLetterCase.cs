

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class POutgoingLetterCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("POUTGOINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }
    [Table("POUTGOINGLETTERCASE")]
    public partial class POutgoingLetterCase : POutgoingLetterCaseBase { }

    }


