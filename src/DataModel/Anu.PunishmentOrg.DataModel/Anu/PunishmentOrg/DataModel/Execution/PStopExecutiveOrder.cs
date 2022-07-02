

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Execution
{
    public abstract class PStopExecutiveOrderBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("ENDSTOPDATE")]
        public virtual string? EndStopDate { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("OFFICECOURTNUMBER")]
        public virtual long? OfficeCourtNumber { get; set; }

        [Column("ORDERTEXT")]
        public virtual string? OrderText { get; set; }

        [Column("RESTARTORDERLETTERDATE")]
        public virtual string? RestartOrderLetterDate { get; set; }

        [Column("RESTARTORDERLETTERNO")]
        public virtual string? RestartOrderLetterNo { get; set; }

        [Column("STARTSTOPDATE")]
        public virtual string? StartStopDate { get; set; }

        [Column("STOPORDERLETTERDATE")]
        public virtual string? StopOrderLetterDate { get; set; }

        [Column("STOPORDERLETTERNO")]
        public virtual string? StopOrderLetterNo { get; set; }

        [Column("SUPREMECOURTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.SupremeCourtType? SupremeCourtType { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePStopExecutiveOrder")]
        public virtual List<Anu.PunishmentOrg.DataModel.Execution.PStopExecutiveOrderUnit>? ThePStopExecutiveOrderUnitList { get; set; }

        [ForeignKey("PUOISSUERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? ThePUOIssuerUnit { get; set; }

        [ForeignKey("REGISTERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheRegisterUnit { get; set; }

    }

    [Table("PSTOPEXECUTIVEORDER")]
    public partial class PStopExecutiveOrder : PStopExecutiveOrderBase
    {
    }
}