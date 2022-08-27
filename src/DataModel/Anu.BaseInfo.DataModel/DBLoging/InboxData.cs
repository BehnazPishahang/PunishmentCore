using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class InboxDataBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("APPLIEDDATETIME")]
        public virtual string? AppliedDateTime { get; set; }

        [Unicode(false)]
        [Column("CHANGEDATETIME")]
        public virtual string? ChangeDateTime { get; set; }

        [Column("CHANGEDTRANSACTIONCMDLOG")]
        public virtual byte[]? ChangedTransactionCmdLog { get; set; }

        [Column("COMMANDPRIORITY")]
        public virtual long? CommandPriority { get; set; }

        [Unicode(false)]
        [Column("COMMANDTYPE")]
        public virtual string? CommandType { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION", TypeName = "BLOB")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("GETDATADATETIME")]
        public virtual string? GetDataDateTime { get; set; }

        [Column("RUNSTATE")]
        public virtual Anu.BaseInfo.Enumerations.RunState? RunState { get; set; }

        [Column("SENDTOBACKUPSERVER")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SendToBackUpServer { get; set; }

        [Column("SEQUENCENUMBER")]
        public virtual long? SequenceNumber { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("SENDDATACMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheSendDataCMSOrganization { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [Unicode(false)]
        [Column("TMP_IP")]
        public virtual string? Tmp_Ip { get; set; }

        [Column("TRANSACTIONCOMMANDLOG")]
        public virtual byte[]? TransactionCommandLog { get; set; }

        }

    [Table("INBOXDATA")]
    public partial class InboxData : InboxDataBase
    {
    }
    }