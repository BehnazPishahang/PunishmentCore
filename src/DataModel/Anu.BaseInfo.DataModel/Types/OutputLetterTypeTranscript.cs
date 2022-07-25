

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class OutputLetterTypeTranscriptBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [ForeignKey("OUTPUTLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.OutputLetterType? TheOutputLetterType { get; set; }

        [Column("TRANSCRIPTTEXT")]
        public virtual string? TranscriptText { get; set; }

    }

    [Table("OUTPUTLETTERTYPETRANSCRIPT")]
    public partial class OutputLetterTypeTranscript : OutputLetterTypeTranscriptBase
    {
    }
}