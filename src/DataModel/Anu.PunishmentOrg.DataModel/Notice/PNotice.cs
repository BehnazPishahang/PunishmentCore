

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Notice
{
    public abstract class PNoticeBase : PunishmentOrgEntity<string>
    {

        [Column("ADDRESSTYPE")]
        public virtual Anu.BaseInfo.Enumerations.AddressType? AddressType { get; set; }

        [Unicode(false)]
        [Column("AGENTFAMILY")]
        public virtual string? AgentFamily { get; set; }

        [Unicode(false)]
        [Column("AGENTNAME")]
        public virtual string? AgentName { get; set; }

        [Unicode(false)]
        [Column("CASESNOSUBNO")]
        public virtual string? CasesNoSubno { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DELIVERFAMILY")]
        public virtual string? DeliverFamily { get; set; }

        [Unicode(false)]
        [Column("DELIVERNAME")]
        public virtual string? DeliverName { get; set; }

        [Unicode(false)]
        [Column("DELIVERPOST")]
        public virtual string? DeliverPost { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("EMAILTEXT")]
        public virtual string? EMailText { get; set; }

        [Column("HOWNOTIFIED")]
        public virtual Anu.BaseInfo.Enumerations.HowNotified? HowNotified { get; set; }

        [Column("INPUTSTATISTIC")]
        public virtual long? InputStatistic { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

        [Column("ISVIEWEDONSITE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsViewedOnSite { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("NOTICECERTIFICATION")]
        public virtual string? NoticeCertification { get; set; }

        [Unicode(false)]
        [Column("NOTICEDATE")]
        public virtual string? NoticeDate { get; set; }

        [Column("NOTICEFINALRESULT")]
        public virtual Anu.BaseInfo.Enumerations.NoticeFinalResult? NoticeFinalResult { get; set; }

        [Unicode(false)]
        [Column("NOTICEORDER")]
        public virtual string? NoticeOrder { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONADDRESS")]
        public virtual string? NoticePersonAddress { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONEMAILADDRESS")]
        public virtual string? NoticePersonEMailAddress { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONFAMILY")]
        public virtual string? NoticePersonFamily { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONFATHERNAME")]
        public virtual string? NoticePersonFatherName { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONMOBILENUMBER")]
        public virtual string? NoticePersonMobileNumber { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONNAME")]
        public virtual string? NoticePersonName { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONPOSTBOX")]
        public virtual string? NoticePersonPostBox { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSONPOSTCODE")]
        public virtual string? NoticePersonPostCode { get; set; }

        [Column("NOTICEPERSONSEX")]
        public virtual Anu.BaseInfo.Enumerations.SexType? NoticePersonSex { get; set; }

        [Unicode(false)]
        [Column("PRESENCEDATE")]
        public virtual string? PresenceDate { get; set; }

        [Unicode(false)]
        [Column("PRESENCETIME")]
        public virtual string? PresenceTime { get; set; }

        [Unicode(false)]
        [Column("PRINTNOTICEDATE")]
        public virtual string? PrintNoticeDate { get; set; }

        [Unicode(false)]
        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [Unicode(false)]
        [Column("SMSTEXT")]
        public virtual string? SMSText { get; set; }

        [ForeignKey("GNOTICETYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GNoticeType? TheGNoticeType { get; set; }

        [ForeignKey("NOTICERESULTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.NoticeResultType? TheNoticeResultType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PNOTICEADVERTISINGID")]
        public virtual Anu.PunishmentOrg.DataModel.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

        [InverseProperty("ThePNotice")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeDefect>? ThePNoticeDefectList { get; set; }

        [InverseProperty("ThePNotice")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeDoc>? ThePNoticeDocList { get; set; }

        [InverseProperty("ThePNotice")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticePerson>? ThePNoticePersonList { get; set; }

        [InverseProperty("ThePNotice")]
        public virtual List<Anu.PunishmentOrg.DataModel.Notice.PNoticeUnit>? ThePNoticeUnitList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PNOTICE")]
    public partial class PNotice : PNoticeBase
    {
    }
    }