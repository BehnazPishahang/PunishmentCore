

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportFieldMathExpBase : BaseInfoEntity<string>
    {

		[Column("FIRSTOPERANDTYPE")]
		public virtual Anu.Enumerations.JOperandType? FirstOperandType { get; set; }

		[Column("LEFTPARENTHESE")]
		public virtual decimal? LeftParenthese { get; set; }

		[Column("OPERAND")]
		public virtual decimal? Operand { get; set; }

		[Column("OPERANDDESCRIPTION")]
		public virtual string? OperandDescription { get; set; }

		[Column("OPERATOR")]
		public virtual Anu.Enumerations.MathOperator? Operator { get; set; }

		[Column("RIGHTPARENTHESE")]
		public virtual decimal? RightParenthese { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[ForeignKey("JTABLEREPORTCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

		[ForeignKey("JTABLEREPORTFIELDMATHCNDEXPID")]
		public virtual Anu.DynamicFormGen.JTableReportFieldMathCndExp? TheJTableReportFieldMathCndExp { get; set; }

		[ForeignKey("OPERANDFIELDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheOperandField { get; set; }

    }
    [Table("JTABLEREPORTFIELDMATHEXP")]
    public partial class JTableReportFieldMathExp : JTableReportFieldMathExpBase { }

    }


