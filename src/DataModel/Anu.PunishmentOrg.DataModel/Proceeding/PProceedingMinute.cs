

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Proceeding
{
    public abstract class PProceedingMinuteBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("ENDTIME")]
        public virtual string? EndTime { get; set; }

        [Unicode(false)]
        [Column("MEETINGDATE")]
        public virtual string? MeetingDate { get; set; }

        [Unicode(false)]
        [Column("MINUTETEXT")]
        public virtual string? MinuteText { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
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