

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PRevisionRequestBase : PunishmentOrgEntity<string>
    {

		[Column("CASESNOSUBNO")]
		public virtual string? CasesNoSubno { get; set; }

		[Column("CONTRABANDOPINION")]
		public virtual Anu.Enumerations.PunishmentOrg.PUContrabandOpinion? ContrabandOpinion { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("HIGHREVISIONPOST")]
		public virtual Anu.Enumerations.PunishmentOrg.PURevisionRequestHighRevisionPost? HighRevisionPost { get; set; }

		[Column("JUDGEDATE")]
		public virtual string? JudgeDate { get; set; }

		[Column("JUDGENO")]
		public virtual string? JudgeNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("REQDATE")]
		public virtual string? ReqDate { get; set; }

		[Column("REQUESTSUBJECT")]
		public virtual Anu.Enumerations.PunishmentOrg.PURevisionRequestSubject? RequestSubject { get; set; }

		[Column("REVISIONPOST")]
		public virtual Anu.Enumerations.PunishmentOrg.PURevisionRequestRevisionPost? RevisionPost { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePRevisionRequest")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseInput>? ThePCaseInputList { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePRevisionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestAsker>? ThePRevisionRequestAskerList { get; set; }

		[InverseProperty("ThePRevisionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestCase>? ThePRevisionRequestCaseList { get; set; }

		[InverseProperty("ThePRevisionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestTriple>? ThePRevisionRequestTripleList { get; set; }

		[InverseProperty("ThePRevisionRequest")]
		public virtual List<Anu.PunishmentOrg.Letter.PRevisionRequestUnit>? ThePRevisionRequestUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TRIPADVISOROPINION")]
		public virtual Anu.Enumerations.PunishmentOrg.PUTripAdvisorOpinion? TripAdvisorOpinion { get; set; }

    }
    [Table("PREVISIONREQUEST")]
    public partial class PRevisionRequest : PRevisionRequestBase { }

    }


