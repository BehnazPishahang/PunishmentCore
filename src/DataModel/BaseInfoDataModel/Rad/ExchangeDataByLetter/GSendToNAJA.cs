

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GSendToNAJABase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("DISCIPLE")]
		public virtual string? Disciple { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RECEVERDATETIME")]
		public virtual string? ReceverDateTime { get; set; }

		[Column("RECEVERNO")]
		public virtual string? ReceverNo { get; set; }

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
		public virtual Rad.ExchangeDataByLetter.GReceiveFromNAJA? TheGReceiveFromNAJA { get; set; }

		[InverseProperty("TheGSendToNAJA")]
		public virtual List<Rad.ExchangeDataByLetter.GSendToNAJACases>? TheGSendToNAJACasesList { get; set; }

		[InverseProperty("TheGSendToNAJA")]
		public virtual List<Rad.ExchangeDataByLetter.GSendToNAJAFields>? TheGSendToNAJAFieldsList { get; set; }

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
    [Table("GSENDTONAJA")]
    public partial class GSendToNAJA : GSendToNAJABase { }

    }


