

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class OutputLetterTypeTranscriptBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [ForeignKey("OUTPUTLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.OutputLetterType? TheOutputLetterType { get; set; }

        [Unicode(false)]
        [Column("TRANSCRIPTTEXT")]
        public virtual string? TranscriptText { get; set; }

    }

    [Table("OUTPUTLETTERTYPETRANSCRIPT")]
    public partial class OutputLetterTypeTranscript : OutputLetterTypeTranscriptBase
    {
    }
    }