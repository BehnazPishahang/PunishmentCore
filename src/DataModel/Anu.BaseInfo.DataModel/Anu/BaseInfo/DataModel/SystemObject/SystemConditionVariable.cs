

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemConditionVariableBase : BaseInfoEntity<string>
    {

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Column("LATINNAME")]
        public virtual string? LatinName { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Column("TYPE")]
        public virtual Anu.BaseInfo.Enumerations.WorkFlowDataType? Type { get; set; }

    }

    [Table("SYSTEMCONDITIONVARIABLE")]
    public partial class SystemConditionVariable : SystemConditionVariableBase
    {
    }
}