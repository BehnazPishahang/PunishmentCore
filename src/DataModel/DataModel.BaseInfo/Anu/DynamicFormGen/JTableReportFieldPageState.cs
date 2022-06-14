

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportFieldPageStateBase : BaseInfoEntity<string>
    {

		[Column("CONDITIONEXP")]
		public virtual string? ConditionExp { get; set; }

		[Column("INVISIBLEDISABLE")]
		public virtual Anu.Enumerations.InvisibleDisable? InvisibleDisable { get; set; }

		[InverseProperty("TheField4GroupCondition")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldCondition>? TheGroupConditionList { get; set; }

		[ForeignKey("JTABLEREPORTFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

		[ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

    }
    [Table("JTABLEREPORTFIELDPAGESTATE")]
    public partial class JTableReportFieldPageState : JTableReportFieldPageStateBase { }

    }


