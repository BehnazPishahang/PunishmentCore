

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class InboxDataBase : BaseInfoEntity<string>
    {

		[Column("APPLIEDDATETIME")]
		public virtual string? AppliedDateTime { get; set; }

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("CHANGEDTRANSACTIONCMDLOG")]
		public virtual byte[]? ChangedTransactionCmdLog { get; set; }

		[Column("COMMANDPRIORITY")]
		public virtual long? CommandPriority { get; set; }

		[Column("COMMANDTYPE")]
		public virtual string? CommandType { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("GETDATADATETIME")]
		public virtual string? GetDataDateTime { get; set; }

		[Column("RUNSTATE")]
		public virtual Anu.Enumerations.RunState? RunState { get; set; }

		[Column("SENDTOBACKUPSERVER")]
		public virtual Anu.Enumerations.YesNo? SendToBackUpServer { get; set; }

		[Column("SEQUENCENUMBER")]
		public virtual long? SequenceNumber { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("SENDDATACMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheSendDataCMSOrganization { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[Column("TMP_IP")]
		public virtual string? Tmp_Ip { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

    }
    [Table("INBOXDATA")]
    public partial class InboxData : InboxDataBase { }

    }


