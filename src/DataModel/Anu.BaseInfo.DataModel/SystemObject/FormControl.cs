using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemObject
{
    public abstract class FormControlBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("FNAME")]
        public virtual string? FName { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("PARENTCONTROLID")]
        public virtual List<Anu.BaseInfo.DataModel.SystemObject.FormControl>? TheChildControlList { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        }

    [Table("FORMCONTROL")]
    public partial class FormControl : FormControlBase
    {
    }
    }