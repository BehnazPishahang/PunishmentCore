

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemTemplateConditionBase : BaseInfoEntity<string>
    {

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("FARSIPATH")]
        public virtual string? FarsiPath { get; set; }

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