

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class ErrorLogBase : BaseInfoEntity<string>
    {

		[Column("ACTION")]
		public virtual string? Action { get; set; }

		[Column("ERRORDATETIME")]
		public virtual string? ErrorDateTime { get; set; }

		[Column("ERRORTEXT")]
		public virtual string? ErrorText { get; set; }

		[Column("EXTRADATA")]
		public virtual string? ExtraData { get; set; }

		[Column("IP")]
		public virtual string? IP { get; set; }

		[Column("MAINOBJECTID")]
		public virtual string? MainObjectId { get; set; }

		[Column("OBJECTID")]
		public virtual string? ObjectID { get; set; }

		[Column("OS")]
		public virtual string? OS { get; set; }

		[Column("SQLSTATEMENT")]
		public virtual string? SqlStatement { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("ERRORLOG")]
    public partial class ErrorLog : ErrorLogBase { }

    }


