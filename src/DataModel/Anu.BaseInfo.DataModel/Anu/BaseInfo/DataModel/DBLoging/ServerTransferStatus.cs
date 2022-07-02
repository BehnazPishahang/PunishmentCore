

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class ServerTransferStatusBase : BaseInfoEntity<string>
    {

        [Column("COMMANDPRIORITY")]
        public virtual long? CommandPriority { get; set; }

        [Column("LASTEXECUTEDITEM")]
        public virtual long? LastExecutedItem { get; set; }

        [Column("LASTEXECUTEDSTATUS")]
        public virtual Anu.BaseInfo.Enumerations.LastExecuteStatus? LastExecutedStatus { get; set; }

        [Column("LASTRECEIVEDITEM")]
        public virtual long? LastReceivedItem { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

    }

    [Table("SERVERTRANSFERSTATUS")]
    public partial class ServerTransferStatus : ServerTransferStatusBase
    {
    }
}