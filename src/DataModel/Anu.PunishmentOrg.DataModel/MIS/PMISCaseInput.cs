using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCaseInputBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATETIME")]
        public virtual string? EndDateTime { get; set; }

        [Column("SENDERUNITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSenderCaseType? SenderUnitType { get; set; }

        [Unicode(false)]
        [Column("SOURCECASENO")]
        public virtual string? SourceCaseNo { get; set; }

        [Unicode(false)]
        [Column("STARTDATETIME")]
        public virtual string? StartDateTime { get; set; }

        [InverseProperty("TheCreatorCaseInput")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? TheCreativeTripleList { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("PCASEINPUTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseInput? ThePCaseInput { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [ForeignKey("PMISCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCase? ThePMISCase { get; set; }

        [ForeignKey("PREVISIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

        [ForeignKey("PTERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? ThePTerminateOrder { get; set; }

        [InverseProperty("TheRelatedCaseInput")]
        public virtual List<Anu.PunishmentOrg.DataModel.MIS.PMISCaseTriple>? TheRelatedTripleList { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("PMISCASEINPUT")]
    public partial class PMISCaseInput : PMISCaseInputBase
    {
    }
    }