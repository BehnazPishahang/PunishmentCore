

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PNote1Article21ProtestBase : PunishmentOrgEntity<string>
    {

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DISCOVERYMINUTESDATE")]
        public virtual string? DiscoveryMinutesDate { get; set; }

        [Column("DISCOVERYMINUTESNO")]
        public virtual string? DiscoveryMinutesNo { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("REFERDATE")]
        public virtual string? ReferDate { get; set; }

        [Column("REQUESTREASON")]
        public virtual string? RequestReason { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

        [InverseProperty("ThePNote1Article21Protest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PNote1Article21ProtestPrs>? ThePNote1Article21ProtestPrsList { get; set; }

        [InverseProperty("ThePNote1Article21Protest")]
        public virtual List<Anu.PunishmentOrg.DataModel.Gravamen.PNote1Article21ProtestUnit>? ThePNote1Article21ProtestUnitList { get; set; }

        [ForeignKey("RECEIVEUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiveUnit { get; set; }

        [ForeignKey("TRIALUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheTrialUnit { get; set; }

    }

    [Table("PNOTE1ARTICLE21PROTEST")]
    public partial class PNote1Article21Protest : PNote1Article21ProtestBase
    {
    }
}