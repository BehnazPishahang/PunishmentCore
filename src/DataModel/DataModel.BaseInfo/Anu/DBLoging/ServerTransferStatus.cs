

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class ServerTransferStatusBase : BaseInfoEntity<string>
    {

		[Column("COMMANDPRIORITY")]
		public virtual long? CommandPriority { get; set; }

		[Column("LASTEXECUTEDITEM")]
		public virtual long? LastExecutedItem { get; set; }

		[Column("LASTEXECUTEDSTATUS")]
		public virtual Anu.Enumerations.LastExecuteStatus? LastExecutedStatus { get; set; }

		[Column("LASTRECEIVEDITEM")]
		public virtual long? LastReceivedItem { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

    }
    [Table("SERVERTRANSFERSTATUS")]
    public partial class ServerTransferStatus : ServerTransferStatusBase { }

    }


