

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportColConditionBase : BaseInfoEntity<string>
    {

		[Column("ANDOROPERATOR")]
		public virtual Anu.Enumerations.AndOr? AndOrOperator { get; set; }

		[Column("FIRSTOPERANDTYPE")]
		public virtual Anu.Enumerations.OperandType? FirstOperandType { get; set; }

		[Column("LEFTOPERAND")]
		public virtual string? LeftOperand { get; set; }

		[Column("LEFTOPERANDDESCRIPTION")]
		public virtual string? LeftOperandDescription { get; set; }

		[Column("LEFTPARENTHESE")]
		public virtual decimal? LeftParenthese { get; set; }

		[Column("OPERATOR")]
		public virtual Anu.Enumerations.OperatorType? Operator { get; set; }

		[Column("RIGHTOPERAND")]
		public virtual string? RightOperand { get; set; }

		[Column("RIGHTOPERANDDESCRIPTION")]
		public virtual string? RightOperandDescription { get; set; }

		[Column("RIGHTOPERANDPARAMETRTYPE")]
		public virtual Anu.Enumerations.ConditionParameterType? RightOperandParametrType { get; set; }

		[Column("RIGHTPARENTHESE")]
		public virtual decimal? RightParenthese { get; set; }

		[Column("ROWNO")]
		public virtual decimal? RowNo { get; set; }

		[Column("SECONDOPERANDTYPE")]
		public virtual Anu.Enumerations.OperandType? SecondOperandType { get; set; }

		[ForeignKey("JTABLEREPORTCOLUMNID")]
		public virtual Anu.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

    }
    [Table("JTABLEREPORTCOLCONDITION")]
    public partial class JTableReportColCondition : JTableReportColConditionBase { }

    }


