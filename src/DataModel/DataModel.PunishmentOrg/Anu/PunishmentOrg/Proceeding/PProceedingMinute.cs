

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
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
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PBJUDGEMENTTEMPLATETYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBJudgementTemplateType? ThePBJudgementTemplateType { get; set; }

		[InverseProperty("ThePProceedingMinute")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PProceedingMinuteCase>? ThePProceedingMinuteCaseList { get; set; }

		[InverseProperty("ThePProceedingMinute")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PProceedingMinuteIssuer>? ThePProceedingMinuteIssuerList { get; set; }

		[InverseProperty("ThePProceedingMinute")]
		public virtual List<Anu.PunishmentOrg.Proceeding.PProceedingMinuteUnit>? ThePProceedingMinuteUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PPROCEEDINGMINUTE")]
    public partial class PProceedingMinute : PProceedingMinuteBase { }

    }


