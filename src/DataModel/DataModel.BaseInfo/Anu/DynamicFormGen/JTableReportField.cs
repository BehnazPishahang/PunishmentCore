

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DynamicFormGen
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
		public virtual Anu.Enumerations.DisplayMode? DisplayMode { get; set; }

		[Column("HASDECIMALPOINT")]
		public virtual Anu.Enumerations.YesNo? HasDecimalPoint { get; set; }

		[Column("HOWCALCITEM")]
		public virtual Anu.Enumerations.HowCalcItem? HowCalcItem { get; set; }

		[Column("ISGRAYBACKGROUND")]
		public virtual Anu.Enumerations.YesNo? IsGrayBackground { get; set; }

		[Column("ISMANDATORY")]
		public virtual Anu.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("ITEMTYPE")]
		public virtual Anu.Enumerations.TypeValue? ItemType { get; set; }

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
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[ForeignKey("JBITEMTITLEID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBItemTitle? TheJBItemTitle { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[InverseProperty("TheJTableReportField")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldCalcs>? TheJTableReportFieldCalcsList { get; set; }

		[ForeignKey("MAINFIELDID")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldChgFields>? TheJTableReportFieldChgFieldsList { get; set; }

		[InverseProperty("TheJTableReportField")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldCondition>? TheJTableReportFieldConditionList { get; set; }

		[InverseProperty("TheMainField")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldMathCndExp>? TheJTableReportFieldMathCndExpList { get; set; }

		[InverseProperty("TheJTableReportField")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldPageState>? TheJTableReportFieldPageStateList { get; set; }

		[InverseProperty("TheJTableReportField")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldValidator>? TheJTableReportFieldValidatorList { get; set; }

		[ForeignKey("JTABLEREPORTPAGEANDGROUPID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? TheJTableReportPageAndGroup { get; set; }

		[InverseProperty("TheJTableReportField")]
		public virtual List<Anu.DynamicFormGen.JTableReportVisualFeature>? TheJTableReportVisualFeatureList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("USEDINCALC")]
		public virtual Anu.Enumerations.YesNo? UsedInCalc { get; set; }

		[Column("VIEWFIELDNAME")]
		public virtual string? ViewFieldName { get; set; }

    }
    [Table("JTABLEREPORTFIELD")]
    public partial class JTableReportField : JTableReportFieldBase { }

    }


