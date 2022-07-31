

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.MechanizedLetter
{
    public abstract class GMechanizedLetterBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CASESMAINDOCNO")]
        public virtual string? CasesMainDocNo { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("CREATORUSERNAME")]
        public virtual string? CreatorUserName { get; set; }

        [Column("ISSENDBYOUTERORG")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsSendByOuterOrg { get; set; }

        [Unicode(false)]
        [Column("LETTERTEXT")]
        public virtual string? LetterText { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("OUTERORGLETTERDATE")]
        public virtual string? OuterOrgLetterDate { get; set; }

        [Unicode(false)]
        [Column("OUTERORGLETTERNO")]
        public virtual string? OuterOrgLetterNo { get; set; }

        [Unicode(false)]
        [Column("SIGNERLETTERUSERNAME")]
        public virtual string? SignerLetterUserName { get; set; }

        [ForeignKey("GFESUSERACCESSID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

        [InverseProperty("TheGMechanizedLetter")]
        public virtual List<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterCase>? TheGMechanizedLetterCaseList { get; set; }

        [InverseProperty("TheGMechanizedLetter")]
        public virtual List<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterFields>? TheGMechanizedLetterFieldsList { get; set; }

        [InverseProperty("TheGMechanizedLetter")]
        public virtual List<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterReceiver>? TheGMechanizedLetterReceiverList { get; set; }

        [ForeignKey("GMECHANIZEDLETTERTYPEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType? TheGMechanizedLetterType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

        [InverseProperty("TheMainLetter")]
        public virtual List<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterRelLetters>? TheRelLettersList { get; set; }

        [ForeignKey("SENDERINNERORGID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheSenderInnerOrg { get; set; }

        [ForeignKey("SENDEROUTERORGID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheSenderOuterOrg { get; set; }

    }

    [Table("GMECHANIZEDLETTER")]
    public partial class GMechanizedLetter : GMechanizedLetterBase
    {
    }
    }