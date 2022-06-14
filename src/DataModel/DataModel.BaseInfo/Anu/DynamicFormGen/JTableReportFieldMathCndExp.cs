

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportFieldMathCndExpBase : BaseInfoEntity<string>
    {

		[Column("CONDITIONEXP")]
		public virtual string? ConditionExp { get; set; }

		[Column("FIELDMATHEXP")]
		public virtual string? FieldMathExp { get; set; }

		[Column("ISROUND")]
		public virtual Anu.Enumerations.YesNo? IsRound { get; set; }

		[Column("LOOKUPWHERECOND")]
		public virtual string? LookupWhereCond { get; set; }

		[Column("ORDERNO")]
		public virtual decimal? OrderNo { get; set; }

		[Column("ROUNDDIGITNUM")]
		public virtual decimal? RoundDigitNum { get; set; }

		[Column("SCRIPTEXP")]
		public virtual string? ScriptExp { get; set; }

		[InverseProperty("TheJTableReportFieldMathCndExp")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldMathCond>? TheJTableReportFieldMathCondList { get; set; }

		[InverseProperty("TheJTableReportFieldMathCndExp")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldMathExp>? TheJTableReportFieldMathExpList { get; set; }

		[ForeignKey("MAINFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheMainField { get; set; }

    }
    [Table("JTABLEREPORTFIELDMATHCNDEXP")]
    public partial class JTableReportFieldMathCndExp : JTableReportFieldMathCndExpBase { }

    }


