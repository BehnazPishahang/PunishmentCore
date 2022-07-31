

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertMajorBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("EXPERTGROUPID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertGroup? TheExpertGroup { get; set; }

        [InverseProperty("TheExpertMajor")]
        public virtual List<Anu.BaseInfo.DataModel.Expert.ExpertManSubject>? TheExpertManSubjectList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("EXPERTMAJOR")]
    public partial class ExpertMajor : ExpertMajorBase
    {
    }
    }