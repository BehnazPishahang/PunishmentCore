using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Letter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterCaseBase : GOutgoingLetterCase
    {

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("POUTGOINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("POUTGOINGLETTERCASE")]
    public partial class POutgoingLetterCase : POutgoingLetterCaseBase
    {
    }
    }