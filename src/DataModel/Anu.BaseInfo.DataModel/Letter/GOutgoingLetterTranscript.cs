using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Letter
{
    public abstract class GOutgoingLetterTranscriptBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("SENDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TranscriptSendType? SendType { get; set; }

        [ForeignKey("GOUTGOINGLETTERID")]
        public virtual Anu.BaseInfo.DataModel.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

        [Unicode(false)]
        [Column("TRANSCRIPTTEXT")]
        public virtual string? TranscriptText { get; set; }

        }

    [Table("GOUTGOINGLETTERTRANSCRIPT")]
    public partial class GOutgoingLetterTranscript : GOutgoingLetterTranscriptBase
    {
    }
    }