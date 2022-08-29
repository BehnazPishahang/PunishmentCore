using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedMinuteBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CONFIRMDATETIME")]
        public virtual string? ConfirmDateTime { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("MEETINGDATE")]
        public virtual string? MeetingDate { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("ORGCONFIRMDATE")]
        public virtual string? OrgConfirmDate { get; set; }

        [Unicode(false)]
        [Column("SENDDATE")]
        public virtual string? SendDate { get; set; }

        [Unicode(false)]
        [Column("STARTTIME")]
        public virtual string? StartTime { get; set; }

        [ForeignKey("CONFIRMERID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheConfirmer { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [InverseProperty("ThePDestroyedMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicenseForms4>? ThePDestroyedLicenseForms4List { get; set; }

        [InverseProperty("ThePDestroyedMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinuteBoxFiles>? ThePDestroyedMinuteBoxFilesList { get; set; }

        [InverseProperty("ThePDestroyedMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinuteCouncil>? ThePDestroyedMinuteCouncilList { get; set; }

        [InverseProperty("ThePDestroyedMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinuteImages>? ThePDestroyedMinuteImagesList { get; set; }

        [InverseProperty("ThePDestroyedMinute")]
        public virtual List<Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinutePresent>? ThePDestroyedMinutePresentList { get; set; }

        [ForeignKey("REGISTRARID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("PDESTROYEDMINUTE")]
    public partial class PDestroyedMinute : PDestroyedMinuteBase
    {
    }
    }