

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterSendCaseBase : PunishmentOrgEntity<string>
    {

        [Column("LETTERCASESENDTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.POutLetterCaseSendType? LetterCaseSendType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("POUTGOINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    }

    [Table("POUTGOINGLETTERSENDCASE")]
    public partial class POutgoingLetterSendCase : POutgoingLetterSendCaseBase
    {
    }
    }