

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedJudgeBindingSbjBase : PunishmentOrgEntity<string>
    {

        [Column("PENALTYAMOUNT")]
        public virtual decimal? PenaltyAmount { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("PBBINDINGSUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

        [ForeignKey("PDESTROYEDJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedJudge? ThePDestroyedJudge { get; set; }

    }

    [Table("PDESTROYEDJUDGEBINDINGSBJ")]
    public partial class PDestroyedJudgeBindingSbj : PDestroyedJudgeBindingSbjBase
    {
    }
}