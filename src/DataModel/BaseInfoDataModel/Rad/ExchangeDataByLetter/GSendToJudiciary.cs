

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GSendToJudiciaryBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("DISCIPLE")]
		public virtual string? Disciple { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OUTGOINGSUBJECT")]
		public virtual string? OutgoingSubject { get; set; }

		[Column("RECEVERDATETIME")]
		public virtual string? ReceverDateTime { get; set; }

		[Column("RECEVERNO")]
		public virtual string? ReceverNo { get; set; }

		[Column("REFERENCE")]
		public virtual string? Reference { get; set; }

		[Column("RELATEDSIGNERUSERID")]
		public virtual string? RelatedSignerUserId { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SIGNERUSERNAME")]
		public virtual string? SignerUserName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.LetterBetweenOrgState? State { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GRECEIVEFROMJUDICIARYID")]
		public virtual Rad.ExchangeDataByLetter.GReceiveFromJudiciary? TheGReceiveFromJudiciary { get; set; }

		[InverseProperty("TheGSendToJudiciary")]
		public virtual List<Rad.ExchangeDataByLetter.GSendToJudiciaryCases>? TheGSendToJudiciaryCasesList { get; set; }

		[InverseProperty("TheGSendToJudiciary")]
		public virtual List<Rad.ExchangeDataByLetter.GSendToJudiciaryFields>? TheGSendToJudiciaryFieldsList { get; set; }

		[ForeignKey("JUDICIARYUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.JudiciaryUnit? TheJudiciaryUnit { get; set; }

		[ForeignKey("LETTERSUBJECTBETWEENORGTYPEID")]
		public virtual Rad.BaseInfo.ExchangeData.LetterSubjectBetweenOrgType? TheLetterSubjectBetweenOrgType { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[Column("VIEWDATETIME")]
		public virtual string? ViewDateTime { get; set; }

		[Column("VIEWERUSERNAME")]
		public virtual string? ViewerUserName { get; set; }

    }
    [Table("GSENDTOJUDICIARY")]
    public partial class GSendToJudiciary : GSendToJudiciaryBase { }

    }


