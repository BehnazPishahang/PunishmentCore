

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class TempDataNotSendBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMANDTYPE")]
		public virtual Anu.Enumerations.CommandType? CommandType { get; set; }

		[Column("DATAOBJECTID")]
		public virtual string? DataObjectId { get; set; }

		[Column("RECEIVERSERVERID")]
		public virtual string? ReceiverServerId { get; set; }

		[Column("RECEIVERSERVERTYPE")]
		public virtual Anu.Enumerations.ReceiverServerType? ReceiverServerType { get; set; }

		[Column("REGISTRATIONTIME")]
		public virtual string? RegistrationTime { get; set; }

		[Column("SENDERCMSORGANIZATIONID")]
		public virtual string? SenderCMSOrganizationId { get; set; }

		[Column("SYSTEMOBJECTID")]
		public virtual string? SystemObjectId { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual long? TransactionOrderNo { get; set; }

    }
    [Table("TEMPDATANOTSEND")]
    public partial class TempDataNotSend : TempDataNotSendBase { }

    }


