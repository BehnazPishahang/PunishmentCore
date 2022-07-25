

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportColMathCndExpBase : BaseInfoEntity<string>
    {

        [Column("APPLICANTTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ApplicantType? ApplicantType { get; set; }

        [Column("COLUMNMATHEXP")]
        public virtual string? ColumnMathExp { get; set; }

        [Column("CONDITIONEXP")]
        public virtual string? ConditionExp { get; set; }

        [Column("EXPERISIONRUNTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ExperisionRunType? ExperisionRunType { get; set; }

        [Column("ISROUND")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRound { get; set; }

        [Column("LOOKUPWHERECOND")]
        public virtual string? LookupWhereCond { get; set; }

        [Column("ORDERNO")]
        public virtual decimal? OrderNo { get; set; }

        [Column("ROUNDDIGITNUM")]
        public virtual decimal? RoundDigitNum { get; set; }

        [Column("SCRIPTEXP")]
        public virtual string? ScriptExp { get; set; }

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [InverseProperty("TheJTableReportColMathCndExp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumnMathCond>? TheJTableReportColumnMathCondList { get; set; }

        [InverseProperty("TheJTableReportColMathCndExp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumnMathExp>? TheJTableReportColumnMathExpList { get; set; }

        [ForeignKey("MAINCOLUMNID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn? TheMainColumn { get; set; }

    }

    [Table("JTABLEREPORTCOLMATHCNDEXP")]
    public partial class JTableReportColMathCndExp : JTableReportColMathCndExpBase
    {
    }
}