using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertBackgroundBase : BaseInfoEntity<string>
    {

        [Column("EXPERTSTATE")]
        public virtual Anu.BaseInfo.Enumerations.ExpertState? ExpertState { get; set; }

        [Unicode(false)]
        [Column("FROMDATE")]
        public virtual string? FromDate { get; set; }

        [ForeignKey("EXPERTMANID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMan? TheExpertMan { get; set; }

        [Unicode(false)]
        [Column("TODATE")]
        public virtual string? ToDate { get; set; }

        }

    [Table("EXPERTBACKGROUND")]
    public partial class ExpertBackground : ExpertBackgroundBase
    {
    }
    }