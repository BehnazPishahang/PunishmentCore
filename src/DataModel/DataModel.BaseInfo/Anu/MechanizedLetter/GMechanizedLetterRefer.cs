

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.MechanizedLetter
{
    public abstract class GMechanizedLetterReferBase : BaseInfoEntity<string>
    {

		[Column("RECEIVERTYPE")]
		public virtual Anu.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

		[Column("REFERNUMBER")]
		public virtual long? ReferNumber { get; set; }

		[Column("REFERORDER")]
		public virtual string? ReferOrder { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SENDTYPE")]
		public virtual Anu.Enumerations.MLetterSendTYpe? SendType { get; set; }

		[ForeignKey("GMECHANIZEDLETTERRECEIVERID")]
		public virtual Anu.MechanizedLetter.GMechanizedLetterReceiver? TheGMechanizedLetterReceiver { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERORGID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheReceiverOrg { get; set; }

		[ForeignKey("RECEIVERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheReceiverRoleType { get; set; }

		[ForeignKey("RECEIVERUSERANDPOSTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheReceiverUserAndPost { get; set; }

		[ForeignKey("SENDERUSERANDPOSTID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheSenderUserAndPost { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GMECHANIZEDLETTERREFER")]
    public partial class GMechanizedLetterRefer : GMechanizedLetterReferBase { }

    }


