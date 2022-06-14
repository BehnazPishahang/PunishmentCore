

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GProcessAttachmentTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("ATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.Types.AttachmentType? TheAttachmentType { get; set; }

		[ForeignKey("GPROCESSID")]
		public virtual Rad.BaseInfo.GProcess.GProcess? TheGProcess { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GPROCESSATTACHMENTTYPE")]
    public partial class GProcessAttachmentType : GProcessAttachmentTypeBase { }

    }


