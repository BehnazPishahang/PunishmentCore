

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterCaseBase : BaseInfoEntity<string>
    {

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[ForeignKey("GMECHANIZEDLETTERCASETYPEID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetterCaseType? TheGMechanizedLetterCaseType { get; set; }

		[ForeignKey("RELATEDCASECLASSID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

		[ForeignKey("RELATEDCASEFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("GMECHANIZEDLETTERCASE")]
    public partial class GMechanizedLetterCase : GMechanizedLetterCaseBase { }

    }


