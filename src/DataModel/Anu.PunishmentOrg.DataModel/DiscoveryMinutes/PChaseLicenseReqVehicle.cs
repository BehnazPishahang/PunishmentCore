using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;


namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqVehicleBase : PChaseLicenseReqObject
    {

        [Unicode(false)]
        [Column("COLOR")]
        public virtual string? Color { get; set; }

        [Unicode(false)]
        [Column("DRIVERFAMILY")]
        public virtual string? DriverFamily { get; set; }

        [Unicode(false)]
        [Column("DRIVERNAME")]
        public virtual string? DriverName { get; set; }

        [Unicode(false)]
        [Column("IRANNUMBER")]
        public virtual string? IranNumber { get; set; }

        [Unicode(false)]
        [Column("MODEL")]
        public virtual string? Model { get; set; }

        [Unicode(false)]
        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Unicode(false)]
        [Column("OWNERFAMILY")]
        public virtual string? OwnerFamily { get; set; }

        [Unicode(false)]
        [Column("OWNERNAME")]
        public virtual string? OwnerName { get; set; }

        [Unicode(false)]
        [Column("PLAQUENUMBER")]
        public virtual string? PlaqueNumber { get; set; }

        [Column("PLAQUESCRIPT")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueScript? PlaqueScript { get; set; }

        [Unicode(false)]
        [Column("PLAQUETHREEDIGIT")]
        public virtual string? PlaqueThreeDigit { get; set; }

        [Unicode(false)]
        [Column("PLAQUETWODIGIT")]
        public virtual string? PlaqueTwoDigit { get; set; }

        [Column("PLAQUETYPE")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueType? PlaqueType { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [Column("VEHICLETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

    
        [Column("TIMESTAMP")]
        [ConcurrencyCheck]
        public long PTimestamp { get { return base.Timestamp; } set {} }
    }

    [Table("PCHASELICENSEREQVEHICLE")]
    public partial class PChaseLicenseReqVehicle : PChaseLicenseReqVehicleBase
    {
    }
    }