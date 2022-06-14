

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
{
    public abstract class JTableReportColumnMathExpBase : BaseInfoEntity<string>
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

		[ForeignKey("JTABLEREPORTCOLMATHCNDEXPID")]
		public virtual Anu.DynamicFormGen.JTableReportColMathCndExp? TheJTableReportColMathCndExp { get; set; }

		[ForeignKey("OPERANDCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheOperandColumn { get; set; }

    }
    [Table("JTABLEREPORTCOLUMNMATHEXP")]
    public partial class JTableReportColumnMathExp : JTableReportColumnMathExpBase { }

    }


