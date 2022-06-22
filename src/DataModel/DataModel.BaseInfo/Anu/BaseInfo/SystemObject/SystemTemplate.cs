

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.SystemObject
{
    public abstract class SystemTemplateBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COMPUTERTEMPLATETEXT")]
		public virtual string? ComputerTemplateText { get; set; }

		[Column("FARSINAME")]
		public virtual string? FarsiName { get; set; }

		[Column("MAINMINORTEMPLATE")]
		public virtual Anu.Enumerations.MainMinorTemplate? MainMinorTemplate { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[ForeignKey("SYSTEMTEMPLATEID")]
		public virtual List<Anu.BaseInfo.SystemObject.SystemTemplateCondition>? TheSystemTemplateConditionList { get; set; }

		[ForeignKey("TEMPLATEHAVELOOPID")]
		public virtual List<Anu.BaseInfo.SystemObject.SystemTemplateLoop>? TheSystemTemplateLoopList { get; set; }

		[ForeignKey("SYSTEMTEMPLATEID")]
		public virtual List<Anu.BaseInfo.SystemObject.SystemTemplateObject>? TheSystemTemplateObjectList { get; set; }

		[ForeignKey("SYSTEMTEMPLATEID")]
		public virtual List<Anu.BaseInfo.SystemObject.SystemTemplateVariable>? TheSystemTemplateVariableList { get; set; }

		[ForeignKey("TEMPLATEUSAGETYPEID")]
		public virtual Anu.BaseInfo.SystemObject.TemplateUsageType? TheTemplateUsageType { get; set; }

		[Column("USERTEMPLATETEXT")]
		public virtual string? UserTemplateText { get; set; }

    }
    [Table("SYSTEMTEMPLATE")]
    public partial class SystemTemplate : SystemTemplateBase { }

    }


