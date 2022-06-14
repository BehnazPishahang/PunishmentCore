

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.NewMechanizedLetter
{
    public abstract class GNWMechanizedLetterReceiverBase : BaseInfoEntity<string>
    {

		[Column("INNEROROUTTERRCVTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterReceiverType? InnerOrOutterRcvType { get; set; }

		[Column("ISMECHANIZERELATION")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMechanizeRelation { get; set; }

		[Column("MAINRCVORTRANSCRIPTRCV")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv? MainRcvOrTranscriptRcv { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[ForeignKey("GNWMECHANIZEDLETTERID")]
		public virtual Rad.NewMechanizedLetter.GNWMechanizedLetter? TheGNWMechanizedLetter { get; set; }

		[InverseProperty("TheGNWMechanizedLetterReceiver")]
		public virtual List<Rad.NewMechanizedLetter.GNWMechanizedLetterRefer>? TheGNWMechanizedLetterReferList { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERINNERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverInnerOrg { get; set; }

		[ForeignKey("RECEIVEROUTORGPOSTID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheReceiverOutOrgPost { get; set; }

		[ForeignKey("RECEIVERPOSTID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheReceiverPost { get; set; }

		[ForeignKey("RECEIVERUSERANDPOSTID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GNWMECHANIZEDLETTERRECEIVER")]
    public partial class GNWMechanizedLetterReceiver : GNWMechanizedLetterReceiverBase { }

    }


