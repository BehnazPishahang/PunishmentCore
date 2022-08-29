using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldMathExpBase : BaseInfoEntity<string>
    {

        [Column("FIRSTOPERANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.JOperandType? FirstOperandType { get; set; }

        [Column("LEFTPARENTHESE")]
        public virtual decimal? LeftParenthese { get; set; }

        [Column("OPERAND")]
        public virtual decimal? Operand { get; set; }

        [Unicode(false)]
        [Column("OPERANDDESCRIPTION")]
        public virtual string? OperandDescription { get; set; }

        [Column("OPERATOR")]
        public virtual Anu.BaseInfo.Enumerations.MathOperator? Operator { get; set; }

        [Column("RIGHTPARENTHESE")]
        public virtual decimal? RightParenthese { get; set; }

        [Column("ROWNO")]
        public virtual decimal? RowNo { get; set; }

        [ForeignKey("JTABLEREPORTCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheJTableReportColumn { get; set; }

        [ForeignKey("JTABLEREPORTFIELDMATHCNDEXPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldMathCndExp? TheJTableReportFieldMathCndExp { get; set; }

        [ForeignKey("OPERANDFIELDID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField? TheOperandField { get; set; }

        }

    [Table("JTABLEREPORTFIELDMATHEXP")]
    public partial class JTableReportFieldMathExp : JTableReportFieldMathExpBase
    {
    }
    }