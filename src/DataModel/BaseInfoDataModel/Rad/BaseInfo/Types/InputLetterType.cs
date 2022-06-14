

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class InputLetterTypeBase : BaseInfoEntity<string>
    {

		[Column("ALLOWABLEATTACHMENTCODES")]
		public virtual string? AllowableAttachmentCodes { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NEEDEDATTACHMENTCODES")]
		public virtual string? NeededAttachmentCodes { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheInputLetterType")]
		public virtual List<Rad.BaseInfo.Types.InputLetterTypeField>? TheInputLetterTypeFieldList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("INPUTLETTERTYPE")]
    public partial class InputLetterType : InputLetterTypeBase { }

    }


