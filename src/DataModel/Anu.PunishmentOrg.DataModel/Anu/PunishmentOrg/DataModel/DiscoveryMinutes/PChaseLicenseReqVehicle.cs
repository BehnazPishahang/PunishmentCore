

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqVehicleBase : PunishmentOrgEntity<string>
    {

        [Column("COLOR")]
        public virtual string? Color { get; set; }

        [Column("DRIVERFAMILY")]
        public virtual string? DriverFamily { get; set; }

        [Column("DRIVERNAME")]
        public virtual string? DriverName { get; set; }

        [Column("IRANNUMBER")]
        public virtual string? IranNumber { get; set; }

        [Column("MODEL")]
        public virtual string? Model { get; set; }

        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Column("OWNERFAMILY")]
        public virtual string? OwnerFamily { get; set; }

        [Column("OWNERNAME")]
        public virtual string? OwnerName { get; set; }

        [Column("PLAQUENUMBER")]
        public virtual string? PlaqueNumber { get; set; }

        [Column("PLAQUESCRIPT")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueScript? PlaqueScript { get; set; }

        [Column("PLAQUETHREEDIGIT")]
        public virtual string? PlaqueThreeDigit { get; set; }

        [Column("PLAQUETWODIGIT")]
        public virtual string? PlaqueTwoDigit { get; set; }

        [Column("PLAQUETYPE")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueType? PlaqueType { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [Column("VEHICLETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

    }

    [Table("PCHASELICENSEREQVEHICLE")]
    public partial class PChaseLicenseReqVehicle : PChaseLicenseReqVehicleBase
    {
    }
}