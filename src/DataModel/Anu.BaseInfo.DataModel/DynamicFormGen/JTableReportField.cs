

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportFieldBase : BaseInfoEntity<string>
    {

        [Column("AFFECTEDFIELDSSTRING")]
        public virtual string? AffectedFieldsString { get; set; }

        [Column("COLSPANFIELD")]
        public virtual decimal? ColSpanField { get; set; }

        [Column("COLSPANFIELDLABEL")]
        public virtual decimal? ColSpanFieldLabel { get; set; }

        [Column("COLUMNFIELD")]
        public virtual decimal? ColumnField { get; set; }

        [Column("COLUMNFIELDLABEL")]
        public virtual decimal? ColumnFieldLabel { get; set; }

        [Column("DECIMALPOINTLENGTH")]
        public virtual decimal? DecimalPointLength { get; set; }

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DISPLAYMODE")]
        public virtual Anu.BaseInfo.Enumerations.DisplayMode? DisplayMode { get; set; }

        [Column("HASDECIMALPOINT")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasDecimalPoint { get; set; }

        [Column("HOWCALCITEM")]
        public virtual Anu.BaseInfo.Enumerations.HowCalcItem? HowCalcItem { get; set; }

        [Column("ISGRAYBACKGROUND")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsGrayBackground { get; set; }

        [Column("ISMANDATORY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMandatory { get; set; }

        [Column("ITEMTYPE")]
        public virtual Anu.BaseInfo.Enumerations.TypeValue? ItemType { get; set; }

        [Column("LOOKUPWHERECOND")]
        public virtual string? LookupWhereCond { get; set; }

        [Column("MAXLENGTH")]
        public virtual decimal? MaxLength { get; set; }

        [Column("ORDERCALCNO")]
        public virtual decimal? OrderCalcNo { get; set; }

        [Column("PRINTORDER")]
        public virtual decimal? PrintOrder { get; set; }

        [Column("ROWFIELD")]
        public virtual decimal? RowField { get; set; }

        [Column("ROWFIELDLABEL")]
        public virtual decimal? RowFieldLabel { get; set; }

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("JBITEMTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [InverseProperty("TheJTableReportField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldCalcs>? TheJTableReportFieldCalcsList { get; set; }

        [ForeignKey("MAINFIELDID")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldChgFields>? TheJTableReportFieldChgFieldsList { get; set; }

        [InverseProperty("TheJTableReportField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldCondition>? TheJTableReportFieldConditionList { get; set; }

        [InverseProperty("TheMainField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldMathCndExp>? TheJTableReportFieldMathCndExpList { get; set; }

        [InverseProperty("TheJTableReportField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldPageState>? TheJTableReportFieldPageStateList { get; set; }

        [InverseProperty("TheJTableReportField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldValidator>? TheJTableReportFieldValidatorList { get; set; }

        [ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

        [InverseProperty("TheJTableReportField")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportVisualFeature>? TheJTableReportVisualFeatureList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("USEDINCALC")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? UsedInCalc { get; set; }

        [Column("VIEWFIELDNAME")]
        public virtual string? ViewFieldName { get; set; }

    }

    [Table("JTABLEREPORTFIELD")]
    public partial class JTableReportField : JTableReportFieldBase
    {
    }
}