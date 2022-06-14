

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ServerTransferStatusBase : BaseInfoEntity<string>
    {

		[Column("LASTEXECUTEDITEM")]
		public virtual decimal? LastExecutedItem { get; set; }

		[Column("LASTEXECUTEDSTATUS")]
		public virtual Rad.CMS.Enumerations.LastExecuteStatus? LastExecutedStatus { get; set; }

		[Column("LASTRECEIVEDITEM")]
		public virtual decimal? LastReceivedItem { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

    }
    [Table("SERVERTRANSFERSTATUS")]
    public partial class ServerTransferStatus : ServerTransferStatusBase { }

    }


