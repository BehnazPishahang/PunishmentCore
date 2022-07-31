

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo
{
    public abstract class JBBaseInfoBudgetBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("CODELENGTH")]
        public virtual decimal? CodeLength { get; set; }

        [Unicode(false)]
        [Column("OTHERFIELDS")]
        public virtual string? OtherFields { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheOldRec")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBBaseInfoBudgetConnections>? TheNewConnRecordsList { get; set; }

        [InverseProperty("TheNewRec")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBBaseInfoBudgetConnections>? TheOldConnRecordsList { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("JBBASEINFOBUDGET")]
    public partial class JBBaseInfoBudget : JBBaseInfoBudgetBase
    {
    }
    }