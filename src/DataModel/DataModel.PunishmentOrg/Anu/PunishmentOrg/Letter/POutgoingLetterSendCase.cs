

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class POutgoingLetterSendCaseBase : PunishmentOrgEntity<string>
    {

		[Column("LETTERCASESENDTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.POutLetterCaseSendType? LetterCaseSendType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("POUTGOINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }
    [Table("POUTGOINGLETTERSENDCASE")]
    public partial class POutgoingLetterSendCase : POutgoingLetterSendCaseBase { }

    }


