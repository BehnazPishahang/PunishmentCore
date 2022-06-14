

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeBase : PunishmentOrgEntity<string>
    {

		[Column("ADDRESSTYPE")]
		public virtual Anu.Enumerations.AddressType? AddressType { get; set; }

		[Column("AGENTFAMILY")]
		public virtual string? AgentFamily { get; set; }

		[Column("AGENTNAME")]
		public virtual string? AgentName { get; set; }

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DELIVERFAMILY")]
		public virtual string? DeliverFamily { get; set; }

		[Column("DELIVERNAME")]
		public virtual string? DeliverName { get; set; }

		[Column("DELIVERPOST")]
		public virtual string? DeliverPost { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("EMAILTEXT")]
		public virtual string? EMailText { get; set; }

		[Column("HOWNOTIFIED")]
		public virtual Anu.Enumerations.HowNotified? HowNotified { get; set; }

		[Column("INPUTSTATISTIC")]
		public virtual long? InputStatistic { get; set; }

		[Column("ISPRINTED")]
		public virtual Anu.Enumerations.YesNo? IsPrinted { get; set; }

		[Column("ISVIEWEDONSITE")]
		public virtual Anu.Enumerations.YesNo? IsViewedOnSite { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NOTICECERTIFICATION")]
		public virtual string? NoticeCertification { get; set; }

		[Column("NOTICEDATE")]
		public virtual string? NoticeDate { get; set; }

		[Column("NOTICEFINALRESULT")]
		public virtual Anu.Enumerations.NoticeFinalResult? NoticeFinalResult { get; set; }

		[Column("NOTICEORDER")]
		public virtual string? NoticeOrder { get; set; }

		[Column("NOTICEPERSONADDRESS")]
		public virtual string? NoticePersonAddress { get; set; }

		[Column("NOTICEPERSONEMAILADDRESS")]
		public virtual string? NoticePersonEMailAddress { get; set; }

		[Column("NOTICEPERSONFAMILY")]
		public virtual string? NoticePersonFamily { get; set; }

		[Column("NOTICEPERSONFATHERNAME")]
		public virtual string? NoticePersonFatherName { get; set; }

		[Column("NOTICEPERSONMOBILENUMBER")]
		public virtual string? NoticePersonMobileNumber { get; set; }

		[Column("NOTICEPERSONNAME")]
		public virtual string? NoticePersonName { get; set; }

		[Column("NOTICEPERSONPOSTBOX")]
		public virtual string? NoticePersonPostBox { get; set; }

		[Column("NOTICEPERSONPOSTCODE")]
		public virtual string? NoticePersonPostCode { get; set; }

		[Column("NOTICEPERSONSEX")]
		public virtual Anu.Enumerations.SexType? NoticePersonSex { get; set; }

		[Column("PRESENCEDATE")]
		public virtual string? PresenceDate { get; set; }

		[Column("PRESENCETIME")]
		public virtual string? PresenceTime { get; set; }

		[Column("PRINTNOTICEDATE")]
		public virtual string? PrintNoticeDate { get; set; }

		[Column("SIDENOTE")]
		public virtual string? SideNote { get; set; }

		[Column("SMSTEXT")]
		public virtual string? SMSText { get; set; }

		[ForeignKey("GNOTICETYPEID")]
		public virtual Anu.BaseInfo.Types.GNoticeType? TheGNoticeType { get; set; }

		[ForeignKey("NOTICERESULTTYPEID")]
		public virtual Anu.BaseInfo.Types.NoticeResultType? TheNoticeResultType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PNOTICEADVERTISINGID")]
		public virtual Anu.PunishmentOrg.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

		[InverseProperty("ThePNotice")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeDefect>? ThePNoticeDefectList { get; set; }

		[InverseProperty("ThePNotice")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeDoc>? ThePNoticeDocList { get; set; }

		[InverseProperty("ThePNotice")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticePerson>? ThePNoticePersonList { get; set; }

		[InverseProperty("ThePNotice")]
		public virtual List<Anu.PunishmentOrg.Notice.PNoticeUnit>? ThePNoticeUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PNOTICE")]
    public partial class PNotice : PNoticeBase { }

    }


