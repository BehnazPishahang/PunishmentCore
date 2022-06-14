

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
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
		public virtual decimal? CommandPriority { get; set; }

		[Column("COMMANDTYPE")]
		public virtual string? CommandType { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ERRORLOG")]
		public virtual string? ErrorLog { get; set; }

		[Column("GETDATADATETIME")]
		public virtual string? GetDataDateTime { get; set; }

		[Column("RUNSTATE")]
		public virtual Rad.CMS.Enumerations.RunState? RunState { get; set; }

		[Column("SENDTOBACKUPSERVER")]
		public virtual Rad.CMS.Enumerations.YesNo? SendToBackUpServer { get; set; }

		[Column("SEQUENCENUMBER")]
		public virtual decimal? SequenceNumber { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("SENDDATACMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheSendDataCMSOrganization { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[Column("TMP_IP")]
		public virtual string? Tmp_Ip { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

    }
    [Table("INBOXDATA")]
    public partial class InboxData : InboxDataBase { }

    }


