

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class OutputLetterTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheOutputLetterType")]
        public virtual List<Anu.BaseInfo.DataModel.Types.OutputLetterTypeTranscript>? TheOutputLetterTypeTranscriptList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("OUTPUTLETTERTYPE")]
    public partial class OutputLetterType : OutputLetterTypeBase
    {
    }
}