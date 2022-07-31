

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PGravamenBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("FOLLOWUPNO")]
        public virtual string? FollowUpNo { get; set; }

        [Column("GRAVAMENORREPORT")]
        public virtual Anu.PunishmentOrg.Enumerations.GravamenOrReport? GravamenOrReport { get; set; }

        [Column("HOWDATATYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PU135OrWebSite? HowDataType { get; set; }

        [Unicode(false)]
        [Column("NOTICETEXT")]
        public virtual string? NoticeText { get; set; }

        [Unicode(false)]
        [Column("PETITIONDESCRIPTION")]
        public virtual string? PetitionDescription { get; set; }

        [Unicode(false)]
        [Column("PETITIONREASONS")]
        public virtual string? PetitionReasons { get; set; }

        [Unicode(false)]
        [Column("PETITIONSUBJECT")]
        public virtual string? PetitionSubject { get; set; }

        [Unicode(false)]
        [Column("REJECTREASONTEXT")]
        public virtual string? RejectReasonText { get; set; }

        [Unicode(false)]
        [Column("REPORTERFAMILY")]
        public virtual string? ReporterFamily { get; set; }

        [Unicode(false)]
        [Column("REPORTERMOBILNUMBER")]
        public virtual string? ReporterMobilNumber { get; set; }

        [Unicode(false)]
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