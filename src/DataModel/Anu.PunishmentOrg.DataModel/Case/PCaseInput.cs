﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseInputBase : PunishmentOrgEntity<string>
    {

        [Column("ENDDATETIME")]
        public virtual string? EndDateTime { get; set; }

        [Column("INSPECTIONDATE")]
        public virtual string? InspectionDate { get; set; }

        [Column("INSPECTIONNO")]
        public virtual string? InspectionNo { get; set; }

        [Column("OUTERCASEDATE")]
        public virtual string? OuterCaseDate { get; set; }

        [Column("OUTERCASENO")]
        public virtual string? OuterCaseNo { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SENDERUNITTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PUSenderCaseType? SenderUnitType { get; set; }

        [Column("SOURCECASEARCHIVENO")]
        public virtual string? SourceCaseArchiveNo { get; set; }

        [Column("SOURCECASENO")]
        public virtual string? SourceCaseNo { get; set; }

        [Column("SOURCECASESUBNO")]
        public virtual long? SourceCaseSubNo { get; set; }

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