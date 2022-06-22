

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesDocFoundBase : PunishmentOrgEntity<string>
    {

		[Column("BILLNODOCFOUND")]
		public virtual string? BillNoDocFound { get; set; }

		[Column("CHARACTERISTIC")]
		public virtual string? Characteristic { get; set; }

		[Column("CHARACTERISTICRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.CharacteristicDoc? CharacteristicRN { get; set; }

		[Column("COUNT")]
		public virtual long? Count { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DESCRIPTIONRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DescriptionDoc? DescriptionRN { get; set; }

		[Column("EXPORTER")]
		public virtual string? Exporter { get; set; }

		[Column("ISSUINGDATE")]
		public virtual string? IssuingDate { get; set; }

		[Column("ISSUINGDATERN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.IssuingDateDoc? IssuingDateRN { get; set; }

		[Column("OWNER")]
		public virtual string? Owner { get; set; }

		[Column("OWNERRN")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.OwnerDoc? OwnerRN { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("PDISCOVERYMINUTESID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }
    [Table("PDISCOVERYMINUTESDOCFOUND")]
    public partial class PDiscoveryMinutesDocFound : PDiscoveryMinutesDocFoundBase { }

    }


