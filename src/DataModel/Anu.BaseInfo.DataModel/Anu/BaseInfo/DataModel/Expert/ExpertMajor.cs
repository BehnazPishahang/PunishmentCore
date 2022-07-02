

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertMajorBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("EXPERTGROUPID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertGroup? TheExpertGroup { get; set; }

        [InverseProperty("TheExpertMajor")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertManSubject>? TheExpertManSubjectList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("EXPERTMAJOR")]
    public partial class ExpertMajor : ExpertMajorBase
    {
    }
}