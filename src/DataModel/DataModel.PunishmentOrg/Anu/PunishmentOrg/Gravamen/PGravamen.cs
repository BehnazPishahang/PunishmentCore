

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Gravamen
{
    public abstract class PGravamenBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FOLLOWUPNO")]
		public virtual string? FollowUpNo { get; set; }

		[Column("GRAVAMENORREPORT")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.GravamenOrReport? GravamenOrReport { get; set; }

		[Column("HOWDATATYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PU135OrWebSite? HowDataType { get; set; }

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
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePGravamen")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamenAttachment>? ThePGravamenAttachmentList { get; set; }

		[InverseProperty("ThePGravamen")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamenNoticeHst>? ThePGravamenNoticeHstList { get; set; }

		[InverseProperty("ThePGravamen")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamenPerson>? ThePGravamenPersonList { get; set; }

		[InverseProperty("ThePGravamen")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamenRejectOrDefectRS>? ThePGravamenRejectOrDefectRSList { get; set; }

		[InverseProperty("ThePGravamen")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PGravamenViolation>? ThePGravamenViolationList { get; set; }

		[ForeignKey("RECEIVEUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheReceiveUnit { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

    }
    [Table("PGRAVAMEN")]
    public partial class PGravamen : PGravamenBase { }

    }


