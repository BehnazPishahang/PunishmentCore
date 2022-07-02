

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Destroyed
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