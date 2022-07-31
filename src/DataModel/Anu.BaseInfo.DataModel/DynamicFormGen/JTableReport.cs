

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DynamicFormGen
{
    public abstract class JTableReportBase : BaseInfoEntity<string>
    {

        [Column("CHANGEVIEWTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ViewType? ChangeViewType { get; set; }

        [Unicode(false)]
        [Column("CLIENTHANDLER")]
        public virtual string? ClientHandler { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("ISFIELDCALCONLOAD")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsFieldCalcOnLoad { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("PKCOLUMNNAME")]
        public virtual string? PKColumnName { get; set; }

        [Unicode(false)]
        [Column("REPORTTITLE")]
        public virtual string? ReportTitle { get; set; }

        [Unicode(false)]
        [Column("SERVERHANDLER")]
        public virtual string? ServerHandler { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.OprationSelectedState? State { get; set; }

        [ForeignKey("AFTERRETURNFINALSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheAfterReturnFinalState { get; set; }

        [ForeignKey("FINALSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheFinalState { get; set; }

        [ForeignKey("INITDLLID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheInitDll { get; set; }

        [ForeignKey("JBDLLREGISTERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

        [ForeignKey("JBREPORTTITLEID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBReportTitle? TheJBReportTitle { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JColumnTitle>? TheJColumnTitleList { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportActivity>? TheJTableReportActivityList { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportColumn>? TheJTableReportColumnList { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportField>? TheJTableReportFieldList { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportFuncs>? TheJTableReportFuncsList { get; set; }

        [InverseProperty("TheJTableReport")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPageAndGroup>? TheJTableReportPageAndGroupList { get; set; }

        [ForeignKey("JTABLEREPORTID")]
        public virtual List<Anu.BaseInfo.DataModel.DynamicFormGen.JTableReportPrintDll>? TheJTableReportPrintDllList { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("OTHERTABID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheOtherTab { get; set; }

        [ForeignKey("PRINTDLLID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? ThePrintDll { get; set; }

        [ForeignKey("RETURNFINALSTATECHECKERID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBDLLRegister? TheReturnFinalStateChecker { get; set; }

        [ForeignKey("SAVEFUNCID")]
        public virtual Anu.BaseInfo.DataModel.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheSaveFunc { get; set; }

        [Unicode(false)]
        [Column("VIEWNAME")]
        public virtual string? ViewName { get; set; }

        [Column("VIEWTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ViewType? ViewType { get; set; }

        [Unicode(false)]
        [Column("VISUALCONSTRACTION")]
        public virtual string? VisualConstraction { get; set; }

    }

    [Table("JTABLEREPORT")]
    public partial class JTableReport : JTableReportBase
    {
    }
    }