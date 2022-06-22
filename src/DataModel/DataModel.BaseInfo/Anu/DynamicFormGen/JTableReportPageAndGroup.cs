

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportPageAndGroupBase : BaseInfoEntity<string>
    {

		[Column("CANADDRECORD")]
		public virtual Anu.Enumerations.YesNo? CanAddRecord { get; set; }

		[Column("CANREMOVERECORD")]
		public virtual Anu.Enumerations.YesNo? CanRemoveRecord { get; set; }

		[Column("COLUMNFIELD")]
		public virtual decimal? ColumnField { get; set; }

		[Column("CONDITIONAFFECT")]
		public virtual Anu.Enumerations.ConditionAffect? ConditionAffect { get; set; }

		[Column("CONTROLTYPE")]
		public virtual Anu.Enumerations.GroupControlType? ControlType { get; set; }

		[Column("GRIDNAME")]
		public virtual string? GridName { get; set; }

		[Column("HASTABLEFILTER")]
		public virtual Anu.Enumerations.YesNo? HasTableFilter { get; set; }

		[Column("HASTABLEPAGING")]
		public virtual Anu.Enumerations.YesNo? HasTablePaging { get; set; }

		[Column("LABELCONTROL")]
		public virtual string? LabelControl { get; set; }

		[Column("MINTABLEHIGH")]
		public virtual long? MinTableHigh { get; set; }

		[Column("NUMFREEZELEFTCOLUMN")]
		public virtual long? NumFreezeLeftColumn { get; set; }

		[Column("NUMRECPERPAGE")]
		public virtual long? NumRecPerPage { get; set; }

		[Column("ROWFIELD")]
		public virtual decimal? RowField { get; set; }

		[Column("ROWHEIGHT")]
		public virtual long? RowHeight { get; set; }

		[Column("TABLEHIGH")]
		public virtual long? TableHigh { get; set; }

		[Column("TABLESCOPEAFFECT")]
		public virtual Anu.Enumerations.TableScopeAffect? TableScopeAffect { get; set; }

		[InverseProperty("ThePageControl")]
		public virtual List<Anu.DynamicFormGen.JTableReportPageAndGroup>? TheGroupControlList { get; set; }

		[ForeignKey("JBCALCFUNASSEMBLYID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[InverseProperty("TheJTableReportPageAndGroup")]
		public virtual List<Anu.DynamicFormGen.JColumnTitle>? TheJColumnTitleList { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual Anu.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

		[InverseProperty("TheJTableReportPageAndGroup")]
		public virtual List<Anu.DynamicFormGen.JTableReportColumn>? TheJTableReportColumnList { get; set; }

		[InverseProperty("TheJTableReportPageAndGroup")]
		public virtual List<Anu.DynamicFormGen.JTableReportField>? TheJTableReportFieldList { get; set; }

		[InverseProperty("TheJTableReportPageAndGroup")]
		public virtual List<Anu.DynamicFormGen.JTableReportFieldPageState>? TheJTableReportFieldPageStateList { get; set; }

		[ForeignKey("PAGECONTROLID")]
		public virtual Anu.DynamicFormGen.JTableReportPageAndGroup? ThePageControl { get; set; }

		[InverseProperty("TheDetailGrp")]
		public virtual List<Anu.DynamicFormGen.JTableReportGrpRelation>? TheRelationGrpByDetailList { get; set; }

		[InverseProperty("TheMasterGrp")]
		public virtual List<Anu.DynamicFormGen.JTableReportGrpRelation>? TheRelationGrpByMasterList { get; set; }

    }
    [Table("JTABLEREPORTPAGEANDGROUP")]
    public partial class JTableReportPageAndGroup : JTableReportPageAndGroupBase { }

    }


