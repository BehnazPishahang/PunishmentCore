

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Notice
{
    public abstract class GNoticeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Column("ADDRESSTYPE")]
        public virtual Anu.BaseInfo.Enumerations.AddressType? AddressType { get; set; }

        [Unicode(false)]
        [Column("AGENTFAMILY")]
        public virtual string? AgentFamily { get; set; }

        [Unicode(false)]
        [Column("AGENTNAME")]
        public virtual string? AgentName { get; set; }

        [Unicode(false)]
        [Column("CONFIRMDATETIME")]
        public virtual string? ConfirmDateTime { get; set; }

        [Unicode(false)]
        [Column("CONFIRMERNOTICERESULT")]
        public virtual string? ConfirmerNoticeResult { get; set; }

        [Column("CONFIRMERNOTICESTATE")]
        public virtual Anu.BaseInfo.Enumerations.ConfirmerNoticeState? ConfirmerNoticeState { get; set; }

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
        [Column("EMAILADDRESS")]
        public virtual string? EMailAddress { get; set; }

        [Unicode(false)]
        [Column("EMAILTEXT")]
        public virtual string? EMailText { get; set; }

        [Column("HOWNOTIFIED")]
        public virtual Anu.BaseInfo.Enumerations.HowNotified? HowNotified { get; set; }

        [Column("INPUTSTATISTIC")]
        public virtual long? InputStatistic { get; set; }

        [Column("ISEMAIL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsEMail { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

        [Column("ISRESPITEREQUESTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsRespiteRequested { get; set; }

        [Column("ISSMS")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsSMS { get; set; }

        [Unicode(false)]
        [Column("MOBILENUMBER4SMS")]
        public virtual string? MobileNumber4SMS { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("NOTICEDATE")]
        public virtual string? NoticeDate { get; set; }

        [Column("NOTICEFINALRESULT")]
        public virtual Anu.BaseInfo.Enumerations.NoticeFinalResult? NoticeFinalResult { get; set; }

        [Unicode(false)]
        [Column("NOTICEORDER")]
        public virtual string? NoticeOrder { get; set; }

        [Unicode(false)]
        [Column("NOTICEPERSON")]
        public virtual string? NoticePerson { get; set; }

        [Unicode(false)]
        [Column("POSTBOX")]
        public virtual string? PostBox { get; set; }

        [Unicode(false)]
        [Column("POSTCODE")]
        public virtual string? PostCode { get; set; }

        [Unicode(false)]
        [Column("PRESENCEDATE")]
        public virtual string? PresenceDate { get; set; }

        [Unicode(false)]
        [Column("PRESENCETIME")]
        public virtual string? PresenceTime { get; set; }

        [Unicode(false)]
        [Column("PRINTDATE")]
        public virtual string? PrintDate { get; set; }

        [Column("PRINTINGMULTIPLICITY")]
        public virtual Anu.BaseInfo.Enumerations.SequenceNum? PrintingMultiplicity { get; set; }

        [Unicode(false)]
        [Column("PRINTNOTICEDATE")]
        public virtual string? PrintNoticeDate { get; set; }

        [Unicode(false)]
        [Column("PUBLISHNAME")]
        public virtual string? PublishName { get; set; }

        [Unicode(false)]
        [Column("RECIEVEDATE")]
        public virtual string? RecieveDate { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASEID")]
        public virtual string? RelatedCaseID { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASENO")]
        public virtual string? RelatedCaseNo { get; set; }

        [Unicode(false)]
        [Column("RELATEDCASETITLE")]
        public virtual string? RelatedCaseTitle { get; set; }

        [Unicode(false)]
        [Column("RELATEDPERSONID")]
        public virtual string? RelatedPersonID { get; set; }

        [Unicode(false)]
        [Column("REQUESTBODY")]
        public virtual string? RequestBody { get; set; }

        [Unicode(false)]
        [Column("RESULTREGDATE")]
        public virtual string? ResultRegDate { get; set; }

        [Unicode(false)]
        [Column("SEND2COURTDATE")]
        public virtual string? Send2CourtDate { get; set; }

        [Unicode(false)]
        [Column("SIDENOTE")]
        public virtual string? SideNote { get; set; }

        [Unicode(false)]
        [Column("SMSTEXT")]
        public virtual string? SMSText { get; set; }

        [ForeignKey("CASENOTICEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheCaseNotice { get; set; }

        [ForeignKey("CONFIRMERNOTICEUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheConfirmerNoticeUser { get; set; }

        [ForeignKey("CONFIRMERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

        [ForeignKey("CREATORUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheCreatorUnit { get; set; }

        [ForeignKey("GNOTICEID")]
        public virtual List<Anu.BaseInfo.DataModel.Notice.GNoticeAttachment>? TheGNoticeAttachmentList { get; set; }

        [ForeignKey("GNOTICEID")]
        public virtual List<Anu.BaseInfo.DataModel.Notice.GNoticeDoc>? TheGNoticeDocList { get; set; }

        [InverseProperty("TheGNotice")]
        public virtual List<Anu.BaseInfo.DataModel.Notice.GNoticeTranscript>? TheGNoticeTranscriptList { get; set; }

        [ForeignKey("GNOTICETYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GNoticeType? TheGNoticeType { get; set; }

        [ForeignKey("NOTICERESULTTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.NoticeResultType? TheNoticeResultType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("REGISTEREDUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheRegisteredUser { get; set; }

        [ForeignKey("RESULTREGUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheResultRegUser { get; set; }

        [ForeignKey("SELFNOTIFICATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSelfNotification { get; set; }

        [Column("TYPISTACCESSIBLE")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? TypistAccessible { get; set; }

        [Unicode(false)]
        [Column("USERNO")]
        public virtual string? UserNo { get; set; }

    }

    [Table("GNOTICE")]
    public partial class GNotice : GNoticeBase
    {
    }
    }