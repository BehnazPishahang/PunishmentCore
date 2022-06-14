

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.DBLoging
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
		public virtual Anu.Enumerations.SendDataState? SendDataState { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SEQUENCENUMBER")]
		public virtual long? SequenceNumber { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("DBLOGGINGID")]
		public virtual Anu.DBLoging.DBLogging? TheDBLogging { get; set; }

		[ForeignKey("FORWARDINBOXDATAID")]
		public virtual Anu.DBLoging.InboxData? TheForwardInboxData { get; set; }

		[ForeignKey("SENDERCASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheSenderCaseServer { get; set; }

		[ForeignKey("SENDERCMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

    }
    [Table("RECEIVERDATA")]
    public partial class ReceiverData : ReceiverDataBase { }

    }


