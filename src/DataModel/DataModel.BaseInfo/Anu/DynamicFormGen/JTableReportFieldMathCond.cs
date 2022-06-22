

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportFieldMathCondBase : BaseInfoEntity<string>
    {

		[Column("ANDOROPERATOR")]
		public virtual Anu.Enumerations.AndOr? AndOrOperator { get; set; }

		[Column("CONSTLEFTOPERAND")]
		public virtual decimal? ConstLeftOperand { get; set; }

		[Column("CONSTRIGHTOPERAND")]
		public virtual decimal? ConstRightOperand { get; set; }

		[Column("FIRSTOPERANDTYPE")]
		public virtual Anu.Enumerations.JOperandType? FirstOperandType { get; set; }

		[Column("LEFTOPERANDDESCRIPTION")]
		public virtual string? LeftOperandDescription { get; set; }

		[Column("LEFTPARENTHESE")]
		public virtual decimal? LeftParenthese { get; set; }

		[Column("OPERATOR")]
		public virtual Anu.Enumerations.OperatorType? Operator { get; set; }

		[Column("RIGHTOPERANDDESCRIPTION")]
		public virtual string? RightOperandDescription { get; set; }

		[Column("RIGHTPARENTHESE")]
		public virtual decimal? RightParenthese { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[Column("SECONDOPERANDTYPE")]
		public virtual Anu.Enumerations.JOperandType? SecondOperandType { get; set; }

		[ForeignKey("FIELDLEFTOPERANDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheFieldLeftOperand { get; set; }

		[ForeignKey("FIELDRIGHTOPERANDID")]
		public virtual Anu.DynamicFormGen.JTableReportField? TheFieldRightOperand { get; set; }

		[ForeignKey("JTABLEREPORTFIELDMATHCNDEXPID")]
		public virtual Anu.DynamicFormGen.JTableReportFieldMathCndExp? TheJTableReportFieldMathCndExp { get; set; }

    }
    [Table("JTABLEREPORTFIELDMATHCOND")]
    public partial class JTableReportFieldMathCond : JTableReportFieldMathCondBase { }

    }


