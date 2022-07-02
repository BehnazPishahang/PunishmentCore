

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PProceedingMinuteBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ENDTIME")]
        public virtual string? EndTime { get; set; }

        [Column("MEETINGDATE")]
        public virtual string? MeetingDate { get; set; }

        [Column("MINUTETEXT")]
        public virtual string? MinuteText { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("STARTTIME")]
        public virtual string? StartTime { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBJUDGEMENTTEMPLATETYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBJudgementTemplateType? ThePBJudgementTemplateType { get; set; }

        [InverseProperty("ThePProceedingMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinuteCase>? ThePProceedingMinuteCaseList { get; set; }

        [InverseProperty("ThePProceedingMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinuteIssuer>? ThePProceedingMinuteIssuerList { get; set; }

        [InverseProperty("ThePProceedingMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Proceeding.PProceedingMinuteUnit>? ThePProceedingMinuteUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PPROCEEDINGMINUTE")]
    public partial class PProceedingMinute : PProceedingMinuteBase
    {
    }
}