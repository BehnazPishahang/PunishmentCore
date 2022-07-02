

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("FOLLOWUPNO")]
        public virtual string? FollowUpNo { get; set; }

        [Column("GRAVAMENORREPORT")]
        public virtual Anu.PunishmentOrg.Enumerations.GravamenOrReport? GravamenOrReport { get; set; }

        [Column("HOWDATATYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PU135OrWebSite? HowDataType { get; set; }

        [Column("NOTICETEXT")]
        public virtual string? NoticeText { get; set; }

        [Column("PETITIONDESCRIPTION")]
        public virtual string? PetitionDescription { get; set; }

        [Column("PETITIONREASONS")]
        public virtual string? PetitionReasons { get; set; }

        [Column("PETITIONSUBJECT")]
        public virtual string? PetitionSubject { get; set; }

        [Column("REJECTREASONTEXT")]
        public virtual string? RejectReasonText { get; set; }

        [Column("REPORTERFAMILY")]
        public virtual string? ReporterFamily { get; set; }

        [Column("REPORTERMOBILNUMBER")]
        public virtual string? ReporterMobilNumber { get; set; }

        [Column("REPORTERNAME")]
        public virtual string? ReporterName { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePGravamen")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenAttachment>? ThePGravamenAttachmentList { get; set; }

        [InverseProperty("ThePGravamen")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenNoticeHst>? ThePGravamenNoticeHstList { get; set; }

        [InverseProperty("ThePGravamen")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenPerson>? ThePGravamenPersonList { get; set; }

        [InverseProperty("ThePGravamen")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenRejectOrDefectRS>? ThePGravamenRejectOrDefectRSList { get; set; }

        [InverseProperty("ThePGravamen")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenViolation>? ThePGravamenViolationList { get; set; }

        [ForeignKey("RECEIVEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiveUnit { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

    }

    [Table("PGRAVAMEN")]
    public partial class PGravamen : PGravamenBase
    {
    }
}