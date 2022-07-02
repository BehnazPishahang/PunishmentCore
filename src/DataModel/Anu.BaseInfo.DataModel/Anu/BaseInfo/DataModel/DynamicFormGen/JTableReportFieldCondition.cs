

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldConditionBase : BaseInfoEntity<string>
    {

        [Column("ANDOROPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.AndOr? AndOrOperator { get; set; }

        [Column("FIRSTOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.OperandType? FirstOperandType { get; set; }

        [Column("LEFTOPERAND")]
        public virtual string? LeftOperand { get; set; }

        [Column("LEFTOPERANDDESCRIPTION")]
        public virtual string? LeftOperandDescription { get; set; }

        [Column("LEFTPARENTHESE")]
        public virtual decimal? LeftParenthese { get; set; }

        [Column("OPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.OperatorType? Operator { get; set; }

        [Column("RIGHTOPERAND")]
        public virtual string? RightOperand { get; set; }

        [Column("RIGHTOPERANDDESCRIPTION")]
        public virtual string? RightOperandDescription { get; set; }

        [Column("RIGHTOPERANDPARAMETRTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ConditionParameterType? RightOperandParametrType { get; set; }

        [Column("RIGHTPARENTHESE")]
        public virtual decimal? RightParenthese { get; set; }

        [Column("ROWNO")]
        public virtual decimal? RowNo { get; set; }

        [Column("SECONDOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.OperandType? SecondOperandType { get; set; }

        [ForeignKey("FIELD4GROUPCONDITIONID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldPageState? TheField4GroupCondition { get; set; }

        [ForeignKey("FIELDLEFTOPERANDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheFieldLeftOperand { get; set; }

        [ForeignKey("FIELDRIGHTOPERANDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheFieldRightOperand { get; set; }

        [ForeignKey("JTABLEREPORTFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheJTableReportField { get; set; }

    }

    [Table("JTABLEREPORTFIELDCONDITION")]
    public partial class JTableReportFieldCondition : JTableReportFieldConditionBase
    {
    }
}