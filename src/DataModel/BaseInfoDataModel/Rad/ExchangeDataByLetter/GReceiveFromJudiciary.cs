

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.ExchangeDataByLetter
{
    public abstract class GReceiveFromJudiciaryBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("CREATORUSERNAME")]
		public virtual string? CreatorUserName { get; set; }

		[Column("DISCIPLE")]
		public virtual string? Disciple { get; set; }

		[Column("LETTERDATE")]
		public virtual string? LetterDate { get; set; }

		[Column("LETTERNO")]
		public virtual string? LetterNo { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RECEIVEDATETIME")]
		public virtual string? ReceiveDateTime { get; set; }

		[Column("REFERENCE")]
		public virtual string? Reference { get; set; }

		[Column("SENDDATETIME")]
		public virtual string? SendDateTime { get; set; }

		[Column("SIGNERUSERNAME")]
		public virtual string? SignerUserName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.LetterBetweenOrgState? State { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[InverseProperty("TheGReceiveFromJudiciary")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromJudiciaryCases>? TheGReceiveFromJudiciaryCasesList { get; set; }

		[InverseProperty("TheGReceiveFromJudiciary")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromJudiciaryFields>? TheGReceiveFromJudiciaryFieldsList { get; set; }

		[InverseProperty("TheGReceiveFromJudiciary")]
		public virtual List<Rad.ExchangeDataByLetter.GReceiveFromJudiciaryRefer>? TheGReceiveFromJudiciaryReferList { get; set; }

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
    [Table("GRECEIVEFROMJUDICIARY")]
    public partial class GReceiveFromJudiciary : GReceiveFromJudiciaryBase { }

    }


