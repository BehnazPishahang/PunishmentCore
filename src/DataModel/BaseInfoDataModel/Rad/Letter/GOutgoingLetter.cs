

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
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
		public virtual Rad.CMS.Enumerations.YesNo? IsPrinted { get; set; }

		[Column("LETTEROUTPUTDATE")]
		public virtual string? LetterOutputDate { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PRINTDATE")]
		public virtual string? PrintDate { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.ReceiverLetterUnitType? ReceiverType { get; set; }

		[Column("RECIEVER")]
		public virtual string? Reciever { get; set; }

		[Column("RECIEVERRELATEDID")]
		public virtual string? RecieverRelatedID { get; set; }

		[Column("RECIEVERTYPE")]
		public virtual Rad.CMS.Enumerations.OutgoingLetterRecieverType? RecieverType { get; set; }

		[Column("REGISTEREDDATE")]
		public virtual string? RegisteredDate { get; set; }

		[Column("SENDEDDATE")]
		public virtual string? SendedDate { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.OutgoingLetterState? State { get; set; }

		[ForeignKey("CONFIRMERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheConfirmerUser { get; set; }

		[InverseProperty("TheGOutgoingLetter")]
		public virtual List<Rad.Letter.GOutgoingLetterCase>? TheGOutgoingLetterCaseList { get; set; }

		[ForeignKey("GOUTGOINGLETTERID")]
		public virtual List<Rad.Letter.GOutgoingLetterSubject>? TheGOutgoingLetterSubjectList { get; set; }

		[InverseProperty("TheGOutgoingLetter")]
		public virtual List<Rad.Letter.GOutgoingLetterTranscript>? TheGOutgoingLetterTranscriptList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

		[ForeignKey("SCRIPTORIUMID")]
		public virtual Rad.BaseInfo.OrganizationChart.Scriptorium? TheScriptorium { get; set; }

		[ForeignKey("SENDERUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheSenderUnit { get; set; }

		[ForeignKey("SENDERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheSenderUser { get; set; }

		[Column("URGENCYLETTER")]
		public virtual Rad.CMS.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

    }
    [Table("GOUTGOINGLETTER")]
    public partial class GOutgoingLetter : GOutgoingLetterBase { }

    }


