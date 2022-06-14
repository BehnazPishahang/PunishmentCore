

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Letter
{
    public abstract class GOutgoingLetterCaseBase : BaseInfoEntity<string>
    {

		[Column("CASEMECHANIZESTATE")]
		public virtual Anu.Enumerations.CaseMechanizeState? CaseMechanizeState { get; set; }

		[Column("CASEOWNER")]
		public virtual Anu.Enumerations.CaseOwner? CaseOwner { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[ForeignKey("GOUTGOINGLETTERID")]
		public virtual Anu.Letter.GOutgoingLetter? TheGOutgoingLetter { get; set; }

		[ForeignKey("RELATEDCASECLASSID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

		[ForeignKey("RELATEDCASEFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

    }
    [Table("GOUTGOINGLETTERCASE")]
    public partial class GOutgoingLetterCase : GOutgoingLetterCaseBase { }

    }


