

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.MechanizedLetter
{
    public abstract class GMechanizedLetterReceiverBase : BaseInfoEntity<string>
    {

        [Column("INNEROROUTTERRCVTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterReceiverType? InnerOrOutterRcvType { get; set; }

        [Column("ISMECHANIZERELATION")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsMechanizeRelation { get; set; }

        [Column("MAINRCVORTRANSCRIPTRCV")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv? MainRcvOrTranscriptRcv { get; set; }

        [Column("RECEIVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

        [Unicode(false)]
        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [ForeignKey("GMECHANIZEDLETTERID")]
        public virtual Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

        [InverseProperty("TheGMechanizedLetterReceiver")]
        public virtual List<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetterRefer>? TheGMechanizedLetterReferList { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("RECEIVERINNERORGID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheReceiverInnerOrg { get; set; }

        [ForeignKey("RECEIVEROUTORGPOSTID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheReceiverOutOrgPost { get; set; }

        [ForeignKey("RECEIVEROUTTERORGID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheReceiverOutterOrg { get; set; }

        [ForeignKey("RECEIVERPOSTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheReceiverPost { get; set; }

        [ForeignKey("RECEIVERUSERANDPOSTID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

        [Unicode(false)]
        [Column("TRANSCRIPTTEXT")]
        public virtual string? TranscriptText { get; set; }

        [Unicode(false)]
        [Column("VIEWDATETIME")]
        public virtual string? ViewDateTime { get; set; }

        [Unicode(false)]
        [Column("VIEWERUSERNAME")]
        public virtual string? ViewerUserName { get; set; }

    }

    [Table("GMECHANIZEDLETTERRECEIVER")]
    public partial class GMechanizedLetterReceiver : GMechanizedLetterReceiverBase
    {
    }
    }