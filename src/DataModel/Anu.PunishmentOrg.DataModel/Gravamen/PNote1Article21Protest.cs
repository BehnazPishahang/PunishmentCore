using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Gravamen
{
    public abstract class PNote1Article21ProtestBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYMINUTESDATE")]
        public virtual string? DiscoveryMinutesDate { get; set; }

        [Unicode(false)]
        [Column("DISCOVERYMINUTESNO")]
        public virtual string? DiscoveryMinutesNo { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("REFERDATE")]
        public virtual string? ReferDate { get; set; }

        [Unicode(false)]
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