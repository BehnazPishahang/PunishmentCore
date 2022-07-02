

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Letter
{
    public abstract class PRevisionRequestBase : PunishmentOrgEntity<string>
    {

        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Column("CONTRABANDOPINION")]
        public virtual Anu.PunishmentOrg.Enumerations.PUContrabandOpinion? ContrabandOpinion { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("HIGHREVISIONPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PURevisionRequestHighRevisionPost? HighRevisionPost { get; set; }

        [Column("JUDGEDATE")]
        public virtual string? JudgeDate { get; set; }

        [Column("JUDGENO")]
        public virtual string? JudgeNo { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("REQDATE")]
        public virtual string? ReqDate { get; set; }

        [Column("REQUESTSUBJECT")]
        public virtual Anu.PunishmentOrg.Enumerations.PURevisionRequestSubject? RequestSubject { get; set; }

        [Column("REVISIONPOST")]
        public virtual Anu.PunishmentOrg.Enumerations.PURevisionRequestRevisionPost? RevisionPost { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePRevisionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseInput>? ThePCaseInputList { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePRevisionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestAsker>? ThePRevisionRequestAskerList { get; set; }

        [InverseProperty("ThePRevisionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestCase>? ThePRevisionRequestCaseList { get; set; }

        [InverseProperty("ThePRevisionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestTriple>? ThePRevisionRequestTripleList { get; set; }

        [InverseProperty("ThePRevisionRequest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Letter.PRevisionRequestUnit>? ThePRevisionRequestUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        [Column("TRIPADVISOROPINION")]
        public virtual Anu.PunishmentOrg.Enumerations.PUTripAdvisorOpinion? TripAdvisorOpinion { get; set; }

    }

    [Table("PREVISIONREQUEST")]
    public partial class PRevisionRequest : PRevisionRequestBase
    {
    }
}