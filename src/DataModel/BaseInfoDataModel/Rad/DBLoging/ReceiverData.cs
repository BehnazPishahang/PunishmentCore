

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ReceiverDataBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMANDPRIORITY")]
		public virtual decimal? CommandPriority { get; set; }

		[Column("COMMANDTYPE")]
		public virtual string? CommandType { get; set; }

		[Column("DIRECTCOMMAND")]
		public virtual byte[]? DirectCommand { get; set; }

		[Column("ERRORLOG")]
		public virtual string? ErrorLog { get; set; }

		[Column("SENDDATASTATE")]
		public virtual Rad.CMS.Enumerations.SendDataState? SendDataState { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SEQUENCENUMBER")]
		public virtual decimal? SequenceNumber { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("DBLOGGINGID")]
		public virtual Rad.DBLoging.DBLogging? TheDBLogging { get; set; }

		[ForeignKey("FORWARDINBOXDATAID")]
		public virtual Rad.DBLoging.InboxData? TheForwardInboxData { get; set; }

		[ForeignKey("SENDERCASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheSenderCaseServer { get; set; }

		[ForeignKey("SENDERCMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheSenderCMSOrganization { get; set; }

    }
    [Table("RECEIVERDATA")]
    public partial class ReceiverData : ReceiverDataBase { }

    }


