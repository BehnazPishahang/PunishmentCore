

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class OfflineServiceCallBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FINISHDATETIME")]
		public virtual string? FinishDateTime { get; set; }

		[Column("MAXRUNNINGTIME")]
		public virtual decimal? MaxRunningTime { get; set; }

		[Column("MAXTRYCOUNT")]
		public virtual decimal? MaxTryCount { get; set; }

		[Column("PARAMETERS")]
		public virtual byte[]? Parameters { get; set; }

		[Column("SCHEDULEDATETIME")]
		public virtual string? ScheduleDateTime { get; set; }

		[Column("SERVICENAME")]
		public virtual string? ServiceName { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[Column("SUCCESSFULLSTATE")]
		public virtual Rad.CMS.Enumerations.YesNo? SuccessfullState { get; set; }

		[Column("TASKTITLE")]
		public virtual string? TaskTitle { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual decimal? TransactionOrderNo { get; set; }

		[Column("TRYAGAINPERIOD")]
		public virtual decimal? TryAgainPeriod { get; set; }

    }
    [Table("OFFLINESERVICECALL")]
    public partial class OfflineServiceCall : OfflineServiceCallBase { }

    }


