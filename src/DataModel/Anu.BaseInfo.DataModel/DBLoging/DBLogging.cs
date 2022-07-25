

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class DBLoggingBase : BaseInfoEntity<string>
    {

        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("COMMANDPRIORITY")]
        public virtual long? CommandPriority { get; set; }

        [Column("COMPUTERNAME")]
        public virtual string? ComputerName { get; set; }

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("SESSIONID")]
        public virtual string? SessionId { get; set; }

        [Column("SYNCPROCESSED")]
        public virtual Anu.BaseInfo.Enumerations.SyncProcessed? SyncProcessed { get; set; }

        [ForeignKey("CMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

        [ForeignKey("CMSUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

        [InverseProperty("TheDBLogging")]
        public virtual List<Anu.BaseInfo.DataModel.DBLoging.ReceiverData>? TheReceiverDataList { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [Column("TRANSACTIONCOMMANDLOG")]
        public virtual byte[]? TransactionCommandLog { get; set; }

        [Column("TRANSACTIONORDERNO")]
        public virtual long? TransactionOrderNo { get; set; }

    }

    [Table("DBLOGGING")]
    public partial class DBLogging : DBLoggingBase
    {
    }
}