

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterAttachBase : BaseInfoEntity<string>
    {

		[Column("ATTACHEDDOCUMENT")]
		public virtual byte[]? AttachedDocument { get; set; }

		[Column("ATTACHEDID")]
		public virtual string? AttachedId { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ISSUEDATE")]
		public virtual string? IssueDate { get; set; }

		[Column("LETTERATTACHMENTTYPE")]
		public virtual Rad.CMS.Enumerations.LetterAttachmentType? LetterAttachmentType { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedObject { get; set; }

    }
    [Table("GMECHANIZEDLETTERATTACH")]
    public partial class GMechanizedLetterAttach : GMechanizedLetterAttachBase { }

    }


