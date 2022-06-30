

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PConvictsDatabaseBindingSujBase : PunishmentOrgEntity<string>
    {

        [Column("ENDPENALTYDATE")]
        public virtual string? EndPenaltyDate { get; set; }

        [Column("EXECUTIVESTATUS")]
        public virtual Anu.PunishmentOrg.Enumerations.PUExecutiveStatus? ExecutiveStatus { get; set; }

        [Column("PENALTYAMOUNT")]
        public virtual decimal? PenaltyAmount { get; set; }

        [Column("PENALTYGETTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PenaltyGetType? PenaltyGetType { get; set; }

        [Column("STARTPENALTYDATE")]
        public virtual string? StartPenaltyDate { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBBINDINGSUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

        [ForeignKey("PCONVICTSDATABASEJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PConvictsDatabaseJudge? ThePConvictsDatabaseJudge { get; set; }

    }

    [Table("PCONVICTSDATABASEBINDINGSUJ")]
    public partial class PConvictsDatabaseBindingSuj : PConvictsDatabaseBindingSujBase
    {
    }
}