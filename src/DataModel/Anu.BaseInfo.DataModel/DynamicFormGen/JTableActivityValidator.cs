

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableActivityValidatorBase : BaseInfoEntity<string>
    {

        [Column("ALARMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.AlarmType? AlarmType { get; set; }

        [Column("ISFINALCHECK")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsFinalCheck { get; set; }

        [ForeignKey("ACTIVITYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportActivity? TheActivity { get; set; }

        [InverseProperty("TheJTableActivityValidator")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableActivityVException>? TheJTableActivityVExceptionList { get; set; }

        [ForeignKey("VALIDATORID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheValidator { get; set; }

    }

    [Table("JTABLEACTIVITYVALIDATOR")]
    public partial class JTableActivityValidator : JTableActivityValidatorBase
    {
    }
    }