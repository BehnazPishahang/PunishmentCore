

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class AttachmentTypeBase : BaseInfoEntity<string>
    {

		[Column("ACCEPTABLETYPES")]
		public virtual string? AcceptableTypes { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("MAXACCEPTABLELENGTH")]
		public virtual decimal? MaxAcceptableLength { get; set; }

		[Column("OTHERDATADEFINITION")]
		public virtual string? OtherDataDefinition { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheAttachmentType")]
		public virtual List<Rad.BaseInfo.Types.AttachmentFormType>? TheAttachmentFormTypeList { get; set; }

		[ForeignKey("MAINATTACHMENTTYPEID")]
		public virtual Rad.BaseInfo.Types.MainAttachmentType? TheMainAttachmentType { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("ATTACHMENTTYPE")]
    public partial class AttachmentType : AttachmentTypeBase { }

    }


