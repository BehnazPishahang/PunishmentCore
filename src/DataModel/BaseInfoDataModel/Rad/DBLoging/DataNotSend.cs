

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class DataNotSendBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMANDTYPE")]
		public virtual Rad.CMS.Enumerations.CommandType? CommandType { get; set; }

		[Column("DATAOBJECTID")]
		public virtual string? DataObjectId { get; set; }

		[Column("ERRORMESSAGE")]
		public virtual string? ErrorMessage { get; set; }

		[Column("RECEIVERSERVERTYPE")]
		public virtual Rad.CMS.Enumerations.ReceiverServerType? ReceiverServerType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.DataNotSendState? State { get; set; }

		[ForeignKey("RECEIVERSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheReceiverServer { get; set; }

		[ForeignKey("SENDERCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual decimal? TransactionOrderNo { get; set; }

    }
    [Table("DATANOTSEND")]
    public partial class DataNotSend : DataNotSendBase { }

    }


