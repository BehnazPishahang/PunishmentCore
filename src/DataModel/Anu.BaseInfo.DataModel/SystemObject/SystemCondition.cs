using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemConditionBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("COMPUTERDESCRIPTION")]
        public virtual string? ComputerDescription { get; set; }

        [Unicode(false)]
        [Column("FARSIDESCRIPTION")]
        public virtual string? FarsiDescription { get; set; }

        [Unicode(false)]
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