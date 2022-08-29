using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class FormValidInFormBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ENGLISHFIELDNAME")]
        public virtual string? EnglishFieldName { get; set; }

        [Unicode(false)]
        [Column("FARSIFIELDNAME")]
        public virtual string? FarsiFieldName { get; set; }

        [ForeignKey("MAINFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheMainForm { get; set; }

        [ForeignKey("RELATEDFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheRelatedForm { get; set; }

        }

    [Table("FORMVALIDINFORM")]
    public partial class FormValidInForm : FormValidInFormBase
    {
    }
    }