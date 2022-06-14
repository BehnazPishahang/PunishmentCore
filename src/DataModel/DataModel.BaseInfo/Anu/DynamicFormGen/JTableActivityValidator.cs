

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableActivityValidatorBase : BaseInfoEntity<string>
    {

		[Column("ALARMTYPE")]
		public virtual Anu.Enumerations.AlarmType? AlarmType { get; set; }

		[Column("ISFINALCHECK")]
		public virtual Anu.Enumerations.YesNo? IsFinalCheck { get; set; }

		[ForeignKey("ACTIVITYID")]
		public virtual Anu.DynamicFormGen.JTableReportActivity? TheActivity { get; set; }

		[InverseProperty("TheJTableActivityValidator")]
		public virtual List<Anu.DynamicFormGen.JTableActivityVException>? TheJTableActivityVExceptionList { get; set; }

		[ForeignKey("VALIDATORID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheValidator { get; set; }

    }
    [Table("JTABLEACTIVITYVALIDATOR")]
    public partial class JTableActivityValidator : JTableActivityValidatorBase { }

    }


