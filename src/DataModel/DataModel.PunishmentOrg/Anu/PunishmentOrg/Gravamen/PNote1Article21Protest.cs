

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Gravamen
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
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

		[InverseProperty("ThePNote1Article21Protest")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PNote1Article21ProtestPrs>? ThePNote1Article21ProtestPrsList { get; set; }

		[InverseProperty("ThePNote1Article21Protest")]
		public virtual List<Anu.PunishmentOrg.Gravamen.PNote1Article21ProtestUnit>? ThePNote1Article21ProtestUnitList { get; set; }

		[ForeignKey("RECEIVEUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheReceiveUnit { get; set; }

		[ForeignKey("TRIALUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheTrialUnit { get; set; }

    }
    [Table("PNOTE1ARTICLE21PROTEST")]
    public partial class PNote1Article21Protest : PNote1Article21ProtestBase { }

    }


