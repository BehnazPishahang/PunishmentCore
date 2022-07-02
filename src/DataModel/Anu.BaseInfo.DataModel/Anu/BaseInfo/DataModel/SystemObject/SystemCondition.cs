

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemConditionBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("COMPUTERDESCRIPTION")]
        public virtual string? ComputerDescription { get; set; }

        [Column("FARSIDESCRIPTION")]
        public virtual string? FarsiDescription { get; set; }

        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [ForeignKey("SYSTEMCONDITIONID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemConditionTerm>? TheSystemConditionTermList { get; set; }

        [ForeignKey("SYSTEMCONDITIONID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemConditionVariable>? TheSystemConditionVariableList { get; set; }

    }

    [Table("SYSTEMCONDITION")]
    public partial class SystemCondition : SystemConditionBase
    {
    }
}