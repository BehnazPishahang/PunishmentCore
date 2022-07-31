

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateLoopBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
        [Column("FARSIPATH")]
        public virtual string? FarsiPath { get; set; }

        [Unicode(false)]
        [Column("LATINNAME")]
        public virtual string? LatinName { get; set; }

        [Unicode(false)]
        [Column("LATINPATH")]
        public virtual string? LatinPath { get; set; }

        [Column("ROWNO")]
        public virtual long? RowNo { get; set; }

        [ForeignKey("LOOPTEMPLATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemTemplate? TheLoopTemplate { get; set; }

        [ForeignKey("SYSTEMCONDITIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemCondition? TheSystemCondition { get; set; }

    }

    [Table("SYSTEMTEMPLATELOOP")]
    public partial class SystemTemplateLoop : SystemTemplateLoopBase
    {
    }
    }