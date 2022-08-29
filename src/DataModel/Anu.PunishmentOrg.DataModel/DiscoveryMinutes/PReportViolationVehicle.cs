using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PReportViolationVehicleBase : PunishmentOrgEntity<string>
    {

        [Column("ARRESTEDVEHICLE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ArrestedVehicle { get; set; }

        [Unicode(false)]
        [Column("CHASSISNUMBER")]
        public virtual string? ChassisNumber { get; set; }

        [Unicode(false)]
        [Column("COLOR")]
        public virtual string? color { get; set; }

        [Unicode(false)]
        [Column("DRIVERFULLNAME")]
        public virtual string? DriverFullName { get; set; }

        [Unicode(false)]
        [Column("MODEL")]
        public virtual string? Model { get; set; }

        [Unicode(false)]
        [Column("MOTORNUMBER")]
        public virtual string? MotorNumber { get; set; }

        [Unicode(false)]
        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Unicode(false)]
        [Column("OWNERFULLNAME")]
        public virtual string? OwnerFullName { get; set; }

        [Unicode(false)]
        [Column("PARKFICHENO")]
        public virtual string? ParkFicheNo { get; set; }

        [Unicode(false)]
        [Column("PARKINGNAME")]
        public virtual string? ParkingName { get; set; }

        [Unicode(false)]
        [Column("PLAQUENUMBER")]
        public virtual string? PlaqueNumber { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PREPORTVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

        [Unicode(false)]
        [Column("VEHICLETYPE")]
        public virtual string? VehicleType { get; set; }

        }

    [Table("PREPORTVIOLATIONVEHICLE")]
    public partial class PReportViolationVehicle : PReportViolationVehicleBase
    {
    }
    }