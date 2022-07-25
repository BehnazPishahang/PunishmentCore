

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesOfficerBase : PunishmentOrgEntity<string>
    {

        [Column("DEGREE")]
        public virtual string? Degree { get; set; }

        [Column("DEGREERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DegreeOfficer? DegreeRN { get; set; }

        [Column("DISCOVERYUNIT")]
        public virtual string? DiscoveryUnit { get; set; }

        [Column("FAMILY")]
        public virtual string? Family { get; set; }

        [Column("FATHERNAME")]
        public virtual string? FatherName { get; set; }

        [Column("INSPECTIONCODE")]
        public virtual string? InspectionCode { get; set; }

        [Column("INSPECTIONCODERN")]
        public virtual Anu.PunishmentOrg.Enumerations.InspectionCodeOfficer? InspectionCodeRN { get; set; }

        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PERSONELNO")]
        public virtual string? PersonelNo { get; set; }

        [Column("SYSTEMNAME")]
        public virtual string? SystemName { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

    }

    [Table("PDISCOVERYMINUTESOFFICER")]
    public partial class PDiscoveryMinutesOfficer : PDiscoveryMinutesOfficerBase
    {
    }
}