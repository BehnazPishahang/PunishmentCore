

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ReceiverDataBase : BaseInfoEntity<string>
    {

        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("COMMANDPRIORITY")]
        public virtual long? CommandPriority { get; set; }

        [Column("COMMANDTYPE")]
        public virtual string? CommandType { get; set; }

        [Column("DIRECTCOMMAND")]
        public virtual byte[]? DirectCommand { get; set; }

        [Column("SENDDATASTATE")]
        public virtual Anu.BaseInfo.Enumerations.SendDataState? SendDataState { get; set; }

        [Column("SENDDATETIME")]
        public virtual string? SendDateTime { get; set; }

        [Column("SEQUENCENUMBER")]
        public virtual long? SequenceNumber { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("DBLOGGINGID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.DBLogging? TheDBLogging { get; set; }

        [ForeignKey("FORWARDINBOXDATAID")]
        public virtual Anu.BaseInfo.DataModel.DBLoging.InboxData? TheForwardInboxData { get; set; }

        [ForeignKey("SENDERCASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheSenderCaseServer { get; set; }

        [ForeignKey("SENDERCMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

    }

    [Table("RECEIVERDATA")]
    public partial class ReceiverData : ReceiverDataBase
    {
    }
}