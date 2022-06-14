

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
{
    public abstract class GIncomingLetterCaseBase : BaseInfoEntity<string>
    {

		[Column("CASEMECHANIZESTATE")]
		public virtual Rad.CMS.Enumerations.CaseMechanizeState? CaseMechanizeState { get; set; }

		[Column("CASEOWNER")]
		public virtual Rad.CMS.Enumerations.CaseOwner? CaseOwner { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[ForeignKey("GINCOMINGLETTERID")]
		public virtual Rad.Letter.GIncomingLetter? TheGIncomingLetter { get; set; }

		[ForeignKey("RELATEDCASECLASSID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

		[ForeignKey("RELATEDCASEFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

    }
    [Table("GINCOMINGLETTERCASE")]
    public partial class GIncomingLetterCase : GIncomingLetterCaseBase { }

    }


