

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedMinuteBase : PunishmentOrgEntity<string>
    {

		[Column("CONFIRMDATETIME")]
		public virtual string? ConfirmDateTime { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("MEETINGDATE")]
		public virtual string? MeetingDate { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("ORGCONFIRMDATE")]
		public virtual string? OrgConfirmDate { get; set; }

		[Column("SENDDATE")]
		public virtual string? SendDate { get; set; }

		[Column("STARTTIME")]
		public virtual string? StartTime { get; set; }

		[ForeignKey("CONFIRMERID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheConfirmer { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePDestroyedMinute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedLicenseForms4>? ThePDestroyedLicenseForms4List { get; set; }

		[InverseProperty("ThePDestroyedMinute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedMinuteBoxFiles>? ThePDestroyedMinuteBoxFilesList { get; set; }

		[InverseProperty("ThePDestroyedMinute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedMinuteCouncil>? ThePDestroyedMinuteCouncilList { get; set; }

		[InverseProperty("ThePDestroyedMinute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedMinuteImages>? ThePDestroyedMinuteImagesList { get; set; }

		[InverseProperty("ThePDestroyedMinute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedMinutePresent>? ThePDestroyedMinutePresentList { get; set; }

		[ForeignKey("REGISTRARID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PDESTROYEDMINUTE")]
    public partial class PDestroyedMinute : PDestroyedMinuteBase { }

    }


