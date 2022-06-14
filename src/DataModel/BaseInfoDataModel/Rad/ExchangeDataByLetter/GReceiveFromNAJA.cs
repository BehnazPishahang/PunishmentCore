

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GReceiveFromNAJABase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("DISCIPLE")]
		public virtual string? Disciple { get; set; }

		[Column("LETTERDATE")]
		public virtual string? LetterDate { get; set; }

		[Column("LETTERNO")]
		public virtual string? LetterNo { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("REFERENCE")]
		public virtual string? Reference { get; set; }

		[Column("RELATEDOTHERORG")]
		public virtual Rad.CMS.Enumerations.RelatedOtherOrg? RelatedOtherOrg { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SIGNERUSERNAME")]
		public virtual string? SignerUserName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.LetterBetweenOrgState? State { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GRECEIVEFROMNAJAID")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromNAJACases>? TheGReceiveFromNAJACasesList { get; set; }

		[InverseProperty("TheGReceiveFromNAJA")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromNAJAFields>? TheGReceiveFromNAJAFieldsList { get; set; }

		[InverseProperty("TheGReceiveFromNAJA")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromNAJARefer>? TheGReceiveFromNAJAReferList { get; set; }

		[ForeignKey("GSENDTONAJAID")]
		public virtual Rad.ExchangeDataByLetter.GSendToNAJA? TheGSendToNAJA { get; set; }

		[ForeignKey("LETTERSUBJECTBETWEENORGTYPEID")]
		public virtual Rad.BaseInfo.ExchangeData.LetterSubjectBetweenOrgType? TheLetterSubjectBetweenOrgType { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GRECEIVEFROMNAJA")]
    public partial class GReceiveFromNAJA : GReceiveFromNAJABase { }

    }


