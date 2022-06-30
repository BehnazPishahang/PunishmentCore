

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportColumnMathCondBase : BaseInfoEntity<string>
    {

        [Column("ANDOROPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.AndOr? AndOrOperator { get; set; }

        [Column("CONSTLEFTOPERAND")]
        public virtual decimal? ConstLeftOperand { get; set; }

        [Column("CONSTRIGHTOPERAND")]
        public virtual decimal? ConstRightOperand { get; set; }

        [Column("FIRSTOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.JOperandType? FirstOperandType { get; set; }

        [Column("LEFTOPERANDDESCRIPTION")]
        public virtual string? LeftOperandDescription { get; set; }

        [Column("LEFTPARENTHESE")]
        public virtual decimal? LeftParenthese { get; set; }

        [Column("OPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.OperatorType? Operator { get; set; }

        [Column("RIGHTOPERANDDESCRIPTION")]
        public virtual string? RightOperandDescription { get; set; }

        [Column("RIGHTPARENTHESE")]
        public virtual decimal? RightParenthese { get; set; }

        [Column("ROWNO")]
        public virtual decimal? RowNo { get; set; }

        [Column("SECONDOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.JOperandType? SecondOperandType { get; set; }

        [ForeignKey("COLLEFTOPERANDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheColLeftOperand { get; set; }

        [ForeignKey("COLRIGHTOPERANDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheColRightOperand { get; set; }

        [ForeignKey("JTABLEREPORTCOLMATHCNDEXPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColMathCndExp? TheJTableReportColMathCndExp { get; set; }

    }

    [Table("JTABLEREPORTCOLUMNMATHCOND")]
    public partial class JTableReportColumnMathCond : JTableReportColumnMathCondBase
    {
    }
}