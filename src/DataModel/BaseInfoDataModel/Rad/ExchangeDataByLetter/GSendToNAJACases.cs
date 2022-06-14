

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GSendToNAJACasesBase : BaseInfoEntity<string>
    {

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseID { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDCASETITLE")]
		public virtual string? RelatedCaseTitle { get; set; }

		[ForeignKey("GSENDTONAJAID")]
		public virtual Rad.ExchangeDataByLetter.GSendToNAJA? TheGSendToNAJA { get; set; }

		[ForeignKey("RELATEDCASECLASSID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheRelatedCaseClass { get; set; }

		[ForeignKey("RELATEDCASEFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedCaseForm { get; set; }

    }
    [Table("GSENDTONAJACASES")]
    public partial class GSendToNAJACases : GSendToNAJACasesBase { }

    }


