﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemObject
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
        public virtual Anu.BaseInfo.Enumerations.MainMinorTemplate? MainMinorTemplate { get; set; }

        [Column("STARTDATE")]
        public virtual string? StartDate { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [ForeignKey("SYSTEMTEMPLATEID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemTemplateCondition>? TheSystemTemplateConditionList { get; set; }

        [ForeignKey("TEMPLATEHAVELOOPID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemTemplateLoop>? TheSystemTemplateLoopList { get; set; }

        [ForeignKey("SYSTEMTEMPLATEID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemTemplateObject>? TheSystemTemplateObjectList { get; set; }

        [ForeignKey("SYSTEMTEMPLATEID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.SystemTemplateVariable>? TheSystemTemplateVariableList { get; set; }

        [ForeignKey("TEMPLATEUSAGETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.TemplateUsageType? TheTemplateUsageType { get; set; }

        [Column("USERTEMPLATETEXT")]
        public virtual string? UserTemplateText { get; set; }

    }

    [Table("SYSTEMTEMPLATE")]
    public partial class SystemTemplate : SystemTemplateBase
    {
    }
}