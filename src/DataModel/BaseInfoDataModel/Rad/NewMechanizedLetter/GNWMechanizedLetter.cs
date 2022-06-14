

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.NewMechanizedLetter
{
    public abstract class GNWMechanizedLetterBase : BaseInfoEntity<string>
    {

		[Column("ALLOWSENDSMS")]
		public virtual Rad.CMS.Enumerations.YesNo? AllowSendSMS { get; set; }

		[Column("CASESMAINDOCNO")]
		public virtual string? CasesMainDocNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("ISSENDBYOUTERORG")]
		public virtual Rad.CMS.Enumerations.YesNo? IsSendByOuterOrg { get; set; }

		[Column("LETTERTEXTDB")]
		public virtual string? LetterTextDB { get; set; }

		[Column("LETTERTEXTSEARCH")]
		public virtual string? LetterTextSearch { get; set; }

		[Column("LETTERTEXTST")]
		public virtual Rad.CMS.Enumerations.LargeFieldTextSaveType? LetterTextST { get; set; }

		[Column("MOBILENUMBER")]
		public virtual string? MobileNumber { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OUTERORGLETTERDATE")]
		public virtual string? OuterOrgLetterDate { get; set; }

		[Column("OUTERORGLETTERNO")]
		public virtual string? OuterOrgLetterNo { get; set; }

		[Column("RELATEDRECEIVELETTERNO")]
		public virtual string? RelatedReceiveLetterNo { get; set; }

		[Column("SIDENOTE")]
		public virtual string? SideNote { get; set; }

		[Column("SIGNERLETTERUSERNAME")]
		public virtual string? SignerLetterUserName { get; set; }

		[ForeignKey("GBNWMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLetterType? TheGBNWMechanizedLetterType { get; set; }

		[ForeignKey("GFESUSERACCESSID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

		[InverseProperty("TheGNWMechanizedLetter")]
		public virtual List<Rad.NewMechanizedLetter.GNWMechanizedLetterCase>? TheGNWMechanizedLetterCaseList { get; set; }

		[InverseProperty("TheGNWMechanizedLetter")]
		public virtual List<Rad.NewMechanizedLetter.GNWMechanizedLetterFields>? TheGNWMechanizedLetterFieldsList { get; set; }

		[InverseProperty("TheGNWMechanizedLetter")]
		public virtual List<Rad.NewMechanizedLetter.GNWMechanizedLetterReceiver>? TheGNWMechanizedLetterReceiverList { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVEREXPERTID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReceiverExpert { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[InverseProperty("TheMainLetter")]
		public virtual List<Rad.NewMechanizedLetter.GNWMechanizedLtrRelLetters>? TheRelLettersList { get; set; }

		[ForeignKey("SENDERINNERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderInnerOrg { get; set; }

    }
    [Table("GNWMECHANIZEDLETTER")]
    public partial class GNWMechanizedLetter : GNWMechanizedLetterBase { }

    }


