

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Letter
{
    public abstract class GOutgoingLetterBase : BaseInfoEntity<string>
    {

		[Column("ATTACHMENT")]
		public virtual string? Attachment { get; set; }

		[Column("BACKLETTERSNO")]
		public virtual string? BackLettersNo { get; set; }

		[Column("CONFIRMEDDATE")]
		public virtual string? ConfirmedDate { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FOLLOWERLETTERSNO")]
		public virtual string? FollowerLettersNo { get; set; }

		[Column("ISPRINTED")]
		public virtual Anu.Enumerations.YesNo? IsPrinted { get; set; }

		[Column("LETTEROUTPUTDATE")]
		public virtual string? LetterOutputDate { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PRINTDATE")]
		public virtual string? PrintDate { get; set; }

		[Column("RECIEVER")]
		public virtual string? Reciever { get; set; }

		[Column("RECIEVERTYPE")]
		public virtual Anu.Enumerations.OutgoingLetterRecieverType? RecieverType { get; set; }

		[Column("REGISTEREDDATE")]
		public virtual string? RegisteredDate { get; set; }

		[Column("SENDEDDATE")]
		public virtual string? SendedDate { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.OutgoingLetterState? State { get; set; }

		[ForeignKey("CONFIRMERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

		[InverseProperty("TheGOutgoingLetter")]
		public virtual List<Anu.Letter.GOutgoingLetterCase>? TheGOutgoingLetterCaseList { get; set; }

		[InverseProperty("TheGOutgoingLetter")]
		public virtual List<Anu.Letter.GOutgoingLetterSubject>? TheGOutgoingLetterSubjectList { get; set; }

		[InverseProperty("TheGOutgoingLetter")]
		public virtual List<Anu.Letter.GOutgoingLetterTranscript>? TheGOutgoingLetterTranscriptList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

		[ForeignKey("SENDERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheSenderUnit { get; set; }

		[ForeignKey("SENDERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

		[Column("URGENCYLETTER")]
		public virtual Anu.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

    }
    [Table("GOUTGOINGLETTER")]
    public partial class GOutgoingLetter : GOutgoingLetterBase { }

    }


