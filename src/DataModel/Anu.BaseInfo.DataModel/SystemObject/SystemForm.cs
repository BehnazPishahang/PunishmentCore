using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class SystemFormBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ASSEMBLYNAME")]
        public virtual string? AssemblyName { get; set; }

        [Unicode(false)]
        [Column("CLASSNAME")]
        public virtual string? ClassName { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("ENGLISHNAME")]
        public virtual string? EnglishName { get; set; }

        [Unicode(false)]
        [Column("FARSINAME")]
        public virtual string? FarsiName { get; set; }

        [Unicode(false)]
        [Column("FORMDESIGNERID")]
        public virtual string? FormDesignerId { get; set; }

        [Unicode(false)]
        [Column("FROMVISIBLEINFORM")]
        public virtual string? FromVisibleInForm { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("BASEOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheBaseObject { get; set; }

        [InverseProperty("TheSystemForm")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.FormControl>? TheFormControlList { get; set; }

        [InverseProperty("TheRelatedForm")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.FormValidInForm>? TheMainFormsList { get; set; }

        [InverseProperty("TheMainForm")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.FormValidInForm>? TheRelatedFormsList { get; set; }

        [Unicode(false)]
        [Column("WORKFLOWSTARTER")]
        public virtual string? WorkFlowStarter { get; set; }

        }

    [Table("SYSTEMFORM")]
    public partial class SystemForm : SystemFormBase
    {
    }
    }