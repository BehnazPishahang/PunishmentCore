

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateConditionBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
        [Column("FARSIPATH")]
        public virtual string? FarsiPath { get; set; }

        [Unicode(false)]
        [Column("LATINPATH")]
        public virtual string? LatinPath { get; set; }

        [ForeignKey("SYSTEMCONDITIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemCondition? TheSystemCondition { get; set; }

    }

    [Table("SYSTEMTEMPLATECONDITION")]
    public partial class SystemTemplateCondition : SystemTemplateConditionBase
    {
    }
    }