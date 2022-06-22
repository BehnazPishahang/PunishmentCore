

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterBase : BaseInfoEntity<string>
    {

		[Column("CASESMAINDOCNO")]
		public virtual string? CasesMainDocNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("ISSENDBYOUTERORG")]
		public virtual Anu.Enumerations.YesNo? IsSendByOuterOrg { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OUTERORGLETTERDATE")]
		public virtual string? OuterOrgLetterDate { get; set; }

		[Column("OUTERORGLETTERNO")]
		public virtual string? OuterOrgLetterNo { get; set; }

		[Column("SIGNERLETTERUSERNAME")]
		public virtual string? SignerLetterUserName { get; set; }

		[ForeignKey("GFESUSERACCESSID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Anu.MechanizedLetter.GMechanizedLetterCase>? TheGMechanizedLetterCaseList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Anu.MechanizedLetter.GMechanizedLetterFields>? TheGMechanizedLetterFieldsList { get; set; }

		[InverseProperty("TheGMechanizedLetter")]
		public virtual List<Anu.MechanizedLetter.GMechanizedLetterReceiver>? TheGMechanizedLetterReceiverList { get; set; }

		[ForeignKey("GMECHANIZEDLETTERTYPEID")]
		public virtual Anu.BaseInfo.ExchangeData.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[InverseProperty("TheMainLetter")]
		public virtual List<Anu.MechanizedLetter.GMechanizedLetterRelLetters>? TheRelLettersList { get; set; }

		[ForeignKey("SENDERINNERORGID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderInnerOrg { get; set; }

		[ForeignKey("SENDEROUTERORGID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheSenderOuterOrg { get; set; }

    }
    [Table("GMECHANIZEDLETTER")]
    public partial class GMechanizedLetter : GMechanizedLetterBase { }

    }


