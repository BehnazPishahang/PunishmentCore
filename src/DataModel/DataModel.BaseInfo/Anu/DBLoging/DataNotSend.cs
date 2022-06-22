

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class DataNotSendBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMANDTYPE")]
		public virtual Anu.Enumerations.CommandType? CommandType { get; set; }

		[Column("DATAOBJECTID")]
		public virtual string? DataObjectId { get; set; }

		[Column("RECEIVERSERVERTYPE")]
		public virtual Anu.Enumerations.ReceiverServerType? ReceiverServerType { get; set; }

		[ForeignKey("RECEIVERSERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheReceiverServer { get; set; }

		[ForeignKey("SENDERCMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual long? TransactionOrderNo { get; set; }

    }
    [Table("DATANOTSEND")]
    public partial class DataNotSend : DataNotSendBase { }

    }


