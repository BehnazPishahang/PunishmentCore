

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISCaseInputBase : PunishmentOrgEntity<string>
    {

		[Column("ENDDATETIME")]
		public virtual string? EndDateTime { get; set; }

		[Column("SENDERUNITTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUSenderCaseType? SenderUnitType { get; set; }

		[Column("SOURCECASENO")]
		public virtual string? SourceCaseNo { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[InverseProperty("TheCreatorCaseInput")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? TheCreativeTripleList { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("PCASEINPUTID")]
		public virtual Anu.PunishmentOrg.Case.PCaseInput? ThePCaseInput { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[ForeignKey("PMISCASEID")]
		public virtual Anu.PunishmentOrg.MIS.PMISCase? ThePMISCase { get; set; }

		[ForeignKey("PREVISIONREQUESTID")]
		public virtual Anu.PunishmentOrg.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

		[ForeignKey("PTERMINATEORDERID")]
		public virtual Anu.PunishmentOrg.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

		[InverseProperty("TheRelatedCaseInput")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? TheRelatedTripleList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PMISCASEINPUT")]
    public partial class PMISCaseInput : PMISCaseInputBase { }

    }


