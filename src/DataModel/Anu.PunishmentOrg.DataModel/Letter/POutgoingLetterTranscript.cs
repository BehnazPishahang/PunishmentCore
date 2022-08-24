using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.BaseInfo.DataModel.Letter;


namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class POutgoingLetterTranscriptBase : GOutgoingLetterTranscript
    {

        [ForeignKey("POUTGOINGLETTERID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.POutgoingLetter? ThePOutgoingLetter { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("POUTGOINGLETTERTRANSCRIPT")]
    public partial class POutgoingLetterTranscript : POutgoingLetterTranscriptBase
    {
    }
    }