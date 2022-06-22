

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.DBLoging
{
    public abstract class OfflineServiceCallBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ERRORLOG")]
		public virtual string? ErrorLog { get; set; }

		[Column("FINISHDATETIME")]
		public virtual string? FinishDateTime { get; set; }

		[Column("JSONPARAMETER")]
		public virtual string? JSonParameter { get; set; }

		[Column("MAXRUNNINGTIME")]
		public virtual long? MaxRunningTime { get; set; }

		[Column("MAXTRYCOUNT")]
		public virtual long? MaxTryCount { get; set; }

		[Column("PARAMETERS")]
		public virtual byte[]? Parameters { get; set; }

		[Column("REALTEDOBJECTID")]
		public virtual string? RealtedObjectID { get; set; }

		[Column("RETURNVALUES")]
		public virtual string? ReturnValues { get; set; }

		[Column("SCHEDULEDATETIME")]
		public virtual string? ScheduleDateTime { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[Column("SUCCESSFULLSTATE")]
		public virtual Anu.Enumerations.YesNo? SuccessfullState { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("GOFFLINESERVICETYPEID")]
		public virtual Anu.BaseInfo.Types.GOffLineServiceType? TheGOffLineServiceType { get; set; }

		[InverseProperty("TheOfflineServiceCall")]
		public virtual List<Anu.DBLoging.OfflineServiceCallNotSend>? TheOfflineServiceCallNotSendList { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual long? TransactionOrderNo { get; set; }

		[Column("TRYAGAINPERIOD")]
		public virtual long? TryAgainPeriod { get; set; }

    }
    [Table("OFFLINESERVICECALL")]
    public partial class OfflineServiceCall : OfflineServiceCallBase { }

    }


