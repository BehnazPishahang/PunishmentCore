

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DiscoveryMinutes
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
		public virtual Anu.Enumerations.PlaqueScript? PlaqueScript { get; set; }

		[Column("PLAQUETHREEDIGIT")]
		public virtual string? PlaqueThreeDigit { get; set; }

		[Column("PLAQUETWODIGIT")]
		public virtual string? PlaqueTwoDigit { get; set; }

		[Column("PLAQUETYPE")]
		public virtual Anu.Enumerations.PlaqueType? PlaqueType { get; set; }

		[ForeignKey("PCHASELICENSEREQID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

		[Column("VEHICLETYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.VehicleType? VehicleType { get; set; }

    }
    [Table("PCHASELICENSEREQVEHICLE")]
    public partial class PChaseLicenseReqVehicle : PChaseLicenseReqVehicleBase { }

    }


