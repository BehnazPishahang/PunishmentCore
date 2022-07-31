

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesDocFoundBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("BILLNODOCFOUND")]
        public virtual string? BillNoDocFound { get; set; }

        [Unicode(false)]
        [Column("CHARACTERISTIC")]
        public virtual string? Characteristic { get; set; }

        [Column("CHARACTERISTICRN")]
        public virtual Anu.PunishmentOrg.Enumerations.CharacteristicDoc? CharacteristicRN { get; set; }

        [Column("COUNT")]
        public virtual long? Count { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("DESCRIPTIONRN")]
        public virtual Anu.PunishmentOrg.Enumerations.DescriptionDoc? DescriptionRN { get; set; }

        [Unicode(false)]
        [Column("EXPORTER")]
        public virtual string? Exporter { get; set; }

        [Unicode(false)]
        [Column("ISSUINGDATE")]
        public virtual string? IssuingDate { get; set; }

        [Column("ISSUINGDATERN")]
        public virtual Anu.PunishmentOrg.Enumerations.IssuingDateDoc? IssuingDateRN { get; set; }

        [Unicode(false)]
        [Column("OWNER")]
        public virtual string? Owner { get; set; }

        [Column("OWNERRN")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnerDoc? OwnerRN { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESDOCFOUND")]
    public partial class PDiscoveryMinutesDocFound : PDiscoveryMinutesDocFoundBase
    {
    }
    }