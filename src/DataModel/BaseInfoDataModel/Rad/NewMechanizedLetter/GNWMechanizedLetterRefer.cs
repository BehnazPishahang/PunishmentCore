

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.NewMechanizedLetter
{
    public abstract class GNWMechanizedLetterReferBase : BaseInfoEntity<string>
    {

		[Column("PREVIOUSREFERID")]
		public virtual string? PreviousReferId { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[Column("REFERNUMBER")]
		public virtual decimal? ReferNumber { get; set; }

		[Column("REFERORDER")]
		public virtual string? ReferOrder { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SENDTYPE")]
		public virtual Rad.CMS.Enumerations.MLetterSendTYpe? SendType { get; set; }

		[ForeignKey("GNWMECHANIZEDLETTERRECEIVERID")]
		public virtual Rad.NewMechanizedLetter.GNWMechanizedLetterReceiver? TheGNWMechanizedLetterReceiver { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverOrg { get; set; }

		[ForeignKey("RECEIVERROLETYPEID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSUserRoleType? TheReceiverRoleType { get; set; }

		[ForeignKey("RECEIVERUSERANDPOSTID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

		[ForeignKey("SENDERUSERANDPOSTID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheSenderUserAndPost { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GNWMECHANIZEDLETTERREFER")]
    public partial class GNWMechanizedLetterRefer : GNWMechanizedLetterReferBase { }

    }


