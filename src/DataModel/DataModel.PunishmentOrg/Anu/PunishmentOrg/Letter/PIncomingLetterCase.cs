

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PIncomingLetterCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

    }
    [Table("PINCOMINGLETTERCASE")]
    public partial class PIncomingLetterCase : PIncomingLetterCaseBase { }

    }


