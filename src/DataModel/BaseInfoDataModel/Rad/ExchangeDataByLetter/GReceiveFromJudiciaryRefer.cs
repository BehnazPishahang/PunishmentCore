

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GReceiveFromJudiciaryReferBase : BaseInfoEntity<string>
    {

		[Column("RECEIVEDATETIME")]
		public virtual string? ReceiveDateTime { get; set; }

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

		[ForeignKey("GRECEIVEFROMJUDICIARYID")]
		public virtual Rad.ExchangeDataByLetter.GReceiveFromJudiciary? TheGReceiveFromJudiciary { get; set; }

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

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GRECEIVEFROMJUDICIARYREFER")]
    public partial class GReceiveFromJudiciaryRefer : GReceiveFromJudiciaryReferBase { }

    }


