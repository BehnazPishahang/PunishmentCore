

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PRegistaryTimeBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Unicode(false)]
        [Column("ENDTIME")]
        public virtual string? EndTime { get; set; }

        [Unicode(false)]
        [Column("REGISTERDATE")]
        public virtual string? RegisterDate { get; set; }

        [Unicode(false)]
        [Column("STARTTIME")]
        public virtual string? StartTime { get; set; }

        [ForeignKey("PBRENEWALTIMETYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBRenewalTimeType? ThePBRenewalTimeType { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePRegistaryTime")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PRegistaryTimeCase>? ThePRegistaryTimeCaseList { get; set; }

        [ForeignKey("PTERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Unicode(false)]
        [Column("TIMERESULT")]
        public virtual string? TimeResult { get; set; }

        [Column("TIMESTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PURegisterTimeStatus? TimeStatus { get; set; }

        [Column("TIMETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PURegisterTimeType? TimeType { get; set; }

    }

    [Table("PREGISTARYTIME")]
    public partial class PRegistaryTime : PRegistaryTimeBase
    {
    }
    }