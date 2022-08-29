using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Letter
{
    public abstract class GOutgoingLetterBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ATTACHMENT")]
        public virtual string? Attachment { get; set; }

        [Unicode(false)]
        [Column("BACKLETTERSNO")]
        public virtual string? BackLettersNo { get; set; }

        [Unicode(false)]
        [Column("CONFIRMEDDATE")]
        public virtual string? ConfirmedDate { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Unicode(false)]
        [Column("FOLLOWERLETTERSNO")]
        public virtual string? FollowerLettersNo { get; set; }

        [Column("ISPRINTED")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

        [Unicode(false)]
        [Column("LETTEROUTPUTDATE")]
        public virtual string? LetterOutputDate { get; set; }

        [Unicode(false)]
        [Column("LETTERTEXT", TypeName = "BLOB")]
        public virtual string? LetterText { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("PRINTDATE")]
        public virtual string? PrintDate { get; set; }

        [Unicode(false)]
        [Column("RECIEVER")]
        public virtual string? Reciever { get; set; }

        [Column("RECIEVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.OutgoingLetterRecieverType? RecieverType { get; set; }

        [Unicode(false)]
        [Column("REGISTEREDDATE")]
        public virtual string? RegisteredDate { get; set; }

        [Unicode(false)]
        [Column("SENDEDDATE")]
        public virtual string? SendedDate { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.OutgoingLetterState? State { get; set; }

        [ForeignKey("CONFIRMERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

        [InverseProperty("TheGOutgoingLetter")]
        public virtual List<Anu.BaseInfo.DataModel.Letter.GOutgoingLetterCase>? TheGOutgoingLetterCaseList { get; set; }

        [InverseProperty("TheGOutgoingLetter")]
        public virtual List<Anu.BaseInfo.DataModel.Letter.GOutgoingLetterSubject>? TheGOutgoingLetterSubjectList { get; set; }

        [InverseProperty("TheGOutgoingLetter")]
        public virtual List<Anu.BaseInfo.DataModel.Letter.GOutgoingLetterTranscript>? TheGOutgoingLetterTranscriptList { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("REGISTRARUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

        [ForeignKey("SENDERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheSenderUnit { get; set; }

        [ForeignKey("SENDERUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

        [Column("URGENCYLETTER")]
        public virtual Anu.BaseInfo.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

        }

    [Table("GOUTGOINGLETTER")]
    public partial class GOutgoingLetter : GOutgoingLetterBase
    {
    }
    }