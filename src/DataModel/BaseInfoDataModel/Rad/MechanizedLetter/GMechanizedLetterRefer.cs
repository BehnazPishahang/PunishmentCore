

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.MechanizedLetter
{
    public abstract class GMechanizedLetterReferBase : BaseInfoEntity<string>
    {

		[Column("ISOUTGOING")]
		public virtual bool? IsOutgoing { get; set; }

		[Column("OUTERORGANIZATIONNAME")]
		public virtual string? OuterOrganizationName { get; set; }

		[Column("RECEIVEDATETIME")]
		public virtual string? ReceiveDateTime { get; set; }

		[Column("RECEIVERORGTYPE")]
		public virtual Rad.CMS.Enumerations.GeneralOrganizationType? ReceiverOrgType { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[Column("REFERNUMBER")]
		public virtual decimal? ReferNumber { get; set; }

		[Column("REFERORDER")]
		public virtual string? ReferOrder { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SENDERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeRefererType? SenderType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.ResultType? State { get; set; }

		[ForeignKey("GMECHANIZEDLETTERID")]
		public virtual Rad.MechanizedLetter.GMechanizedLetter? TheGMechanizedLetter { get; set; }

		[InverseProperty("TheGMechanizedLetterRefer")]
		public virtual List<Rad.MechanizedLetter.GMechanizedLetterRcvRefer>? TheGMechanizedLetterRcvReferList { get; set; }

		[ForeignKey("GRECIEVERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.GeneralOrganization? TheGRecieverOrg { get; set; }

		[ForeignKey("GSENDERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.GeneralOrganization? TheGSenderOrg { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVEREMPLOYEEID")]
		public virtual Rad.BaseInfo.OrganizationChart.Employee? TheReceiverEmployee { get; set; }

		[ForeignKey("RECEIVERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverOrg { get; set; }

		[ForeignKey("RECEIVERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheReceiverRoleType { get; set; }

		[ForeignKey("SENDEREMPLOYEEID")]
		public virtual Rad.BaseInfo.OrganizationChart.Employee? TheSenderEmployee { get; set; }

		[ForeignKey("SENDERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderOrg { get; set; }

		[ForeignKey("SENDERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheSenderRoleType { get; set; }

		[Column("TRANSCRIPTTEXT")]
		public virtual string? TranscriptText { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GMECHANIZEDLETTERREFER")]
    public partial class GMechanizedLetterRefer : GMechanizedLetterReferBase { }

    }


