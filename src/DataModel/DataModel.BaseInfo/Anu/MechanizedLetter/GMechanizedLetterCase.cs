

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterCaseBase : BaseInfoEntity<string>
    {

		[Column("CASELOCATION")]
		public virtual Anu.Enumerations.MechanizedLetterCaseLocation? CaseLocation { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("RELATEDCASECLASSID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

		[ForeignKey("RELATEDCASEFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GMECHANIZEDLETTERCASE")]
    public partial class GMechanizedLetterCase : GMechanizedLetterCaseBase { }

    }


