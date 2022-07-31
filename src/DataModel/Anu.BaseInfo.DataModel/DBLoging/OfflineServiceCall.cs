

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.DBLoging
{
    public abstract class OfflineServiceCallBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("ERRORLOG")]
        public virtual string? ErrorLog { get; set; }

        [Unicode(false)]
        [Column("FINISHDATETIME")]
        public virtual string? FinishDateTime { get; set; }

        [Unicode(false)]
        [Column("JSONPARAMETER")]
        public virtual string? JSonParameter { get; set; }

        [Column("MAXRUNNINGTIME")]
        public virtual long? MaxRunningTime { get; set; }

        [Column("MAXTRYCOUNT")]
        public virtual long? MaxTryCount { get; set; }

        [Column("PARAMETERS")]
        public virtual byte[]? Parameters { get; set; }

        [Unicode(false)]
        [Column("REALTEDOBJECTID")]
        public virtual string? RealtedObjectID { get; set; }

        [Unicode(false)]
        [Column("RETURNVALUES")]
        public virtual string? ReturnValues { get; set; }

        [Unicode(false)]
        [Column("SCHEDULEDATETIME")]
        public virtual string? ScheduleDateTime { get; set; }

        [Unicode(false)]
        [Column("STARTDATETIME")]
        public virtual string? StartDateTime { get; set; }

        [Column("SUCCESSFULLSTATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? SuccessfullState { get; set; }

        [ForeignKey("CASESERVERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

        [ForeignKey("GOFFLINESERVICETYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GOffLineServiceType? TheGOffLineServiceType { get; set; }

        [InverseProperty("TheOfflineServiceCall")]
        public virtual List<Anu.BaseInfo.DataModel.DBLoging.OfflineServiceCallNotSend>? TheOfflineServiceCallNotSendList { get; set; }

        [Column("TRANSACTIONORDERNO")]
        public virtual long? TransactionOrderNo { get; set; }

        [Column("TRYAGAINPERIOD")]
        public virtual long? TryAgainPeriod { get; set; }

    }

    [Table("OFFLINESERVICECALL")]
    public partial class OfflineServiceCall : OfflineServiceCallBase
    {
    }
    }