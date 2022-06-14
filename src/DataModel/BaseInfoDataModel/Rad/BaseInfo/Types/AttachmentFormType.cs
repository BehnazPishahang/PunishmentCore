

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class AttachmentFormTypeBase : BaseInfoEntity<string>
    {

		[Column("ISMANDATORY")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMandatory { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[ForeignKey("ATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.Types.AttachmentType? TheAttachmentType { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("ATTACHMENTFORMTYPE")]
    public partial class AttachmentFormType : AttachmentFormTypeBase { }

    }


