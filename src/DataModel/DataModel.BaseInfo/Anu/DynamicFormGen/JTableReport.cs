

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DynamicFormGen
{
    public abstract class JTableReportBase : BaseInfoEntity<string>
    {

		[Column("CHANGEVIEWTYPE")]
		public virtual Anu.Enumerations.ViewType? ChangeViewType { get; set; }

		[Column("CLIENTHANDLER")]
		public virtual string? ClientHandler { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ISFIELDCALCONLOAD")]
		public virtual Anu.Enumerations.YesNo? IsFieldCalcOnLoad { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PKCOLUMNNAME")]
		public virtual string? PKColumnName { get; set; }

		[Column("REPORTTITLE")]
		public virtual string? ReportTitle { get; set; }

		[Column("SERVERHANDLER")]
		public virtual string? ServerHandler { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.OprationSelectedState? State { get; set; }

		[ForeignKey("AFTERRETURNFINALSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheAfterReturnFinalState { get; set; }

		[ForeignKey("FINALSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheFinalState { get; set; }

		[ForeignKey("INITDLLID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheInitDll { get; set; }

		[ForeignKey("JBDLLREGISTERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheJBDLLRegister { get; set; }

		[ForeignKey("JBREPORTTITLEID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBReportTitle? TheJBReportTitle { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JColumnTitle>? TheJColumnTitleList { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JTableReportActivity>? TheJTableReportActivityList { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JTableReportColumn>? TheJTableReportColumnList { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JTableReportField>? TheJTableReportFieldList { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JTableReportFuncs>? TheJTableReportFuncsList { get; set; }

		[InverseProperty("TheJTableReport")]
		public virtual List<Anu.DynamicFormGen.JTableReportPageAndGroup>? TheJTableReportPageAndGroupList { get; set; }

		[ForeignKey("JTABLEREPORTID")]
		public virtual List<Anu.DynamicFormGen.JTableReportPrintDll>? TheJTableReportPrintDllList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("OTHERTABID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheOtherTab { get; set; }

		[ForeignKey("PRINTDLLID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? ThePrintDll { get; set; }

		[ForeignKey("RETURNFINALSTATECHECKERID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBDLLRegister? TheReturnFinalStateChecker { get; set; }

		[ForeignKey("SAVEFUNCID")]
		public virtual Anu.BaseInfo.DynamicFormGenBaseInfo.JBCalcFunAssembly? TheSaveFunc { get; set; }

		[Column("VIEWNAME")]
		public virtual string? ViewName { get; set; }

		[Column("VIEWTYPE")]
		public virtual Anu.Enumerations.ViewType? ViewType { get; set; }

		[Column("VISUALCONSTRACTION")]
		public virtual string? VisualConstraction { get; set; }

    }
    [Table("JTABLEREPORT")]
    public partial class JTableReport : JTableReportBase { }

    }


