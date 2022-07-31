

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportPageAndGroupBase : BaseInfoEntity<string>
    {

        [Column("CANADDRECORD")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? CanAddRecord { get; set; }

        [Column("CANREMOVERECORD")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? CanRemoveRecord { get; set; }

        [Column("COLUMNFIELD")]
        public virtual decimal? ColumnField { get; set; }

        [Column("CONDITIONAFFECT")]
        public virtual Anu.BaseInfo.Enumerations.ConditionAffect? ConditionAffect { get; set; }

        [Column("CONTROLTYPE")]
        public virtual Anu.BaseInfo.Enumerations.GroupControlType? ControlType { get; set; }

        [Unicode(false)]
        [Column("GRIDNAME")]
        public virtual string? GridName { get; set; }

        [Column("HASTABLEFILTER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasTableFilter { get; set; }

        [Column("HASTABLEPAGING")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? HasTablePaging { get; set; }

        [Unicode(false)]
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
        public virtual Anu.BaseInfo.Enumerations.TableScopeAffect? TableScopeAffect { get; set; }

        [InverseProperty("ThePageControl")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup>? TheGroupControlList { get; set; }

        [ForeignKey("JBCALCFUNASSEMBLYID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheJBCalcFunAssembly { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [InverseProperty("TheJTableReportPageAndGroup")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JColumnTitle>? TheJColumnTitleList { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReport? TheJTableReport { get; set; }

        [InverseProperty("TheJTableReportPageAndGroup")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn>? TheJTableReportColumnList { get; set; }

        [InverseProperty("TheJTableReportPageAndGroup")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField>? TheJTableReportFieldList { get; set; }

        [InverseProperty("TheJTableReportPageAndGroup")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFieldPageState>? TheJTableReportFieldPageStateList { get; set; }

        [ForeignKey("PAGECONTROLID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup? ThePageControl { get; set; }

        [InverseProperty("TheDetailGrp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportGrpRelation>? TheRelationGrpByDetailList { get; set; }

        [InverseProperty("TheMasterGrp")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportGrpRelation>? TheRelationGrpByMasterList { get; set; }

    }

    [Table("JTABLEREPORTPAGEANDGROUP")]
    public partial class JTableReportPageAndGroup : JTableReportPageAndGroupBase
    {
    }
    }