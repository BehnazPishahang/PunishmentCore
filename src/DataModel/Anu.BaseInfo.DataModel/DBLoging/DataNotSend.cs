

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class DataNotSendBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("COMMANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.CommandType? CommandType { get; set; }

        [Unicode(false)]
        [Column("DATAOBJECTID")]
        public virtual string? DataObjectId { get; set; }

        [Column("RECEIVERSERVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ReceiverServerType? ReceiverServerType { get; set; }

        [ForeignKey("RECEIVERSERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheReceiverServer { get; set; }

        [ForeignKey("SENDERCMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Column("TRANSACTIONCOMMANDLOG")]
        public virtual byte[]? TransactionCommandLog { get; set; }

        [Column("TRANSACTIONORDERNO")]
        public virtual long? TransactionOrderNo { get; set; }

    }

    [Table("DATANOTSEND")]
    public partial class DataNotSend : DataNotSendBase
    {
    }
    }