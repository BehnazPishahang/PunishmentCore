

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportColumnMathExpBase : BaseInfoEntity<string>
    {

        [Column("FIRSTOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.JOperandType? FirstOperandType { get; set; }

        [Column("LEFTPARENTHESE")]
        public virtual decimal? LeftParenthese { get; set; }

        [Column("OPERAND")]
        public virtual decimal? Operand { get; set; }

        [Column("OPERANDDESCRIPTION")]
        public virtual string? OperandDescription { get; set; }

        [Column("OPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.MathOperator? Operator { get; set; }

        [Column("RIGHTPARENTHESE")]
        public virtual decimal? RightParenthese { get; set; }

        [Column("ROWNO")]
        public virtual decimal? RowNo { get; set; }

        [ForeignKey("JTABLEREPORTCOLMATHCNDEXPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColMathCndExp? TheJTableReportColMathCndExp { get; set; }

        [ForeignKey("OPERANDCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheOperandColumn { get; set; }

    }

    [Table("JTABLEREPORTCOLUMNMATHEXP")]
    public partial class JTableReportColumnMathExp : JTableReportColumnMathExpBase
    {
    }
}