

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseInputBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ENDDATETIME")]
        public virtual string? EndDateTime { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONDATE")]
        public virtual string? InspectionDate { get; set; }

        [Unicode(false)]
        [Column("INSPECTIONNO")]
        public virtual string? InspectionNo { get; set; }

        [Unicode(false)]
        [Column("OUTERCASEDATE")]
        public virtual string? OuterCaseDate { get; set; }

        [Unicode(false)]
        [Column("OUTERCASENO")]
        public virtual string? OuterCaseNo { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SENDERUNITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSenderCaseType? SenderUnitType { get; set; }

        [Unicode(false)]
        [Column("SOURCECASEARCHIVENO")]
        public virtual string? SourceCaseArchiveNo { get; set; }

        [Unicode(false)]
        [Column("SOURCECASENO")]
        public virtual string? SourceCaseNo { get; set; }

        [Column("SOURCECASESUBNO")]
        public virtual long? SourceCaseSubNo { get; set; }

        [Unicode(false)]
        [Column("STARTDATETIME")]
        public virtual string? StartDateTime { get; set; }

        [InverseProperty("TheCreatorCaseInput")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? TheCreativeTripleList { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PREVISIONREQUESTID")]
        public virtual Anu.PunishmentOrg.DataModel.Letter.PRevisionRequest? ThePRevisionRequest { get; set; }

        [InverseProperty("TheRelatedCaseInput")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseTriple>? TheRelatedTripleList { get; set; }

        [ForeignKey("SENDERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheSenderUnit { get; set; }

        [ForeignKey("TERMINATEJUDGEID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? TheTerminateJudge { get; set; }

        [ForeignKey("TERMINATETERMINATEORDERID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PTerminateOrder? TheTerminateTerminateOrder { get; set; }

    }

    [Table("PCASEINPUT")]
    public partial class PCaseInput : PCaseInputBase
    {
    }
    }