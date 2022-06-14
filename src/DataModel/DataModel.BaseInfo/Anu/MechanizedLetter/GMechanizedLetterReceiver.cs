

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterReceiverBase : BaseInfoEntity<string>
    {

		[Column("INNEROROUTTERRCVTYPE")]
		public virtual Anu.Enumerations.MechanizedLetterReceiverType? InnerOrOutterRcvType { get; set; }

		[Column("ISMECHANIZERELATION")]
		public virtual Anu.Enumerations.YesNo? IsMechanizeRelation { get; set; }

		[Column("MAINRCVORTRANSCRIPTRCV")]
		public virtual Anu.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv? MainRcvOrTranscriptRcv { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Anu.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[InverseProperty("TheGMechanizedLetterReceiver")]
		public virtual List<Anu.MechanizedLetter.GMechanizedLetterRefer>? TheGMechanizedLetterReferList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERINNERORGID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverInnerOrg { get; set; }

		[ForeignKey("RECEIVEROUTORGPOSTID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheReceiverOutOrgPost { get; set; }

		[ForeignKey("RECEIVEROUTTERORGID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheReceiverOutterOrg { get; set; }

		[ForeignKey("RECEIVERPOSTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheReceiverPost { get; set; }

		[ForeignKey("RECEIVERUSERANDPOSTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GMECHANIZEDLETTERRECEIVER")]
    public partial class GMechanizedLetterReceiver : GMechanizedLetterReceiverBase { }

    }


