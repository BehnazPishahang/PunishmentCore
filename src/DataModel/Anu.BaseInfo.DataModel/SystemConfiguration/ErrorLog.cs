using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class ErrorLogBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ACTION")]
        public virtual string? Action { get; set; }

        [Unicode(false)]
        [Column("ERRORDATETIME")]
        public virtual string? ErrorDateTime { get; set; }

        [Unicode(false)]
        [Column("ERRORTEXT")]
        public virtual string? ErrorText { get; set; }

        [Unicode(false)]
        [Column("IP")]
        public virtual string? IP { get; set; }

        [Unicode(false)]
        [Column("MAINOBJECTID")]
        public virtual string? MainObjectId { get; set; }

        [Unicode(false)]
        [Column("OS")]
        public virtual string? OS { get; set; }

        [Unicode(false)]
        [Column("SQLSTATEMENT")]
        public virtual string? SqlStatement { get; set; }

        [ForeignKey("CMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        }

    [Table("ERRORLOG")]
    public partial class ErrorLog : ErrorLogBase
    {
    }
    }