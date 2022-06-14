

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemObject
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
		public virtual List<Anu.BaseInfo.SystemObject.SystemConditionTerm>? TheSystemConditionTermList { get; set; }

		[ForeignKey("SYSTEMCONDITIONID")]
		public virtual List<Anu.BaseInfo.SystemObject.SystemConditionVariable>? TheSystemConditionVariableList { get; set; }

    }
    [Table("SYSTEMCONDITION")]
    public partial class SystemCondition : SystemConditionBase { }

    }


