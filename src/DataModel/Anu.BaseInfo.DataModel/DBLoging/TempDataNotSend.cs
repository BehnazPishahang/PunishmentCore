using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class TempDataNotSendBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("COMMANDTYPE")]
        public virtual Anu.BaseInfo.Enumerations.CommandType? CommandType { get; set; }

        [Unicode(false)]
        [Column("DATAOBJECTID")]
        public virtual string? DataObjectId { get; set; }

        [Unicode(false)]
        [Column("RECEIVERSERVERID")]
        public virtual string? ReceiverServerId { get; set; }

        [Column("RECEIVERSERVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.ReceiverServerType? ReceiverServerType { get; set; }

        [Unicode(false)]
        [Column("REGISTRATIONTIME")]
        public virtual string? RegistrationTime { get; set; }

        [Unicode(false)]
        [Column("SENDERCMSORGANIZATIONID")]
        public virtual string? SenderCMSOrganizationId { get; set; }

        [Unicode(false)]
        [Column("SYSTEMOBJECTID")]
        public virtual string? SystemObjectId { get; set; }

        [Column("TRANSACTIONCOMMANDLOG")]
        public virtual byte[]? TransactionCommandLog { get; set; }

        [Column("TRANSACTIONORDERNO")]
        public virtual long? TransactionOrderNo { get; set; }

        }

    [Table("TEMPDATANOTSEND")]
    public partial class TempDataNotSend : TempDataNotSendBase
    {
    }
    }