

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PDiscoveryMinutesVehicleBase : PunishmentOrgEntity<string>
    {

        [Column("ARRESTEDVEHICLE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ArrestedVehicle { get; set; }

        [Column("CHASSISNUMBER")]
        public virtual string? ChassisNumber { get; set; }

        [Column("CHASSISNUMBERRN")]
        public virtual string? ChassisNumberRN { get; set; }

        [Column("COLOR")]
        public virtual string? Color { get; set; }

        [Column("DRIVERFAMILY")]
        public virtual string? DriverFamily { get; set; }

        [Column("DRIVERFULLNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DriverFullName? DriverFullNameRN { get; set; }

        [Column("DRIVERNAME")]
        public virtual string? DriverName { get; set; }

        [Column("IRANNUMBER")]
        public virtual string? IranNumber { get; set; }

        [Column("ISSUEPARKBILLREG")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IssueParkBillReg { get; set; }

        [Column("MODEL")]
        public virtual string? Model { get; set; }

        [Column("MOTORNUMBER")]
        public virtual string? MotorNumber { get; set; }

        [Column("MOTORNUMBERRN")]
        public virtual string? MotorNumberRN { get; set; }

        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Column("OTHERINFORN")]
        public virtual Anu.PunishmentOrg.Enumerations.OtherInfo? OtherInfoRN { get; set; }

        [Column("OWNERFAMILY")]
        public virtual string? OwnerFamily { get; set; }

        [Column("OWNERFULLNAMERN")]
        public virtual string? OwnerFullNameRN { get; set; }

        [Column("OWNERNAME")]
        public virtual string? OwnerName { get; set; }

        [Column("PARKFICHENO")]
        public virtual string? ParkFicheNo { get; set; }

        [Column("PARKINGNAME")]
        public virtual string? ParkingName { get; set; }

        [Column("PLAQUENUMBER")]
        public virtual string? PlaqueNumber { get; set; }

        [Column("PLAQUENUMBERRN")]
        public virtual Anu.PunishmentOrg.Enumerations.PlaqueNumber? PlaqueNumberRN { get; set; }

        [Column("PLAQUESCRIPT")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueScript? PlaqueScript { get; set; }

        [Column("PLAQUETHREEDIGIT")]
        public virtual string? PlaqueThreeDigit { get; set; }

        [Column("PLAQUETWODIGIT")]
        public virtual string? PlaqueTwoDigit { get; set; }

        [Column("PLAQUETYPE")]
        public virtual Anu.BaseInfo.Enumerations.PlaqueType? PlaqueType { get; set; }

        [Column("RECIEVERPARKINGBILL")]
        public virtual string? RecieverParkingBill { get; set; }

        [Column("REGINWAYBILL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? RegInWaybill { get; set; }

        [Column("REGINWAYBILLRN")]
        public virtual Anu.PunishmentOrg.Enumerations.RegInWaybill? RegInWaybillRN { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

        [Column("VEHICLETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

        [Column("WAYBILLNO")]
        public virtual string? WayBillNO { get; set; }

        [Column("WAYBILLNORN")]
        public virtual Anu.PunishmentOrg.Enumerations.WayBillNO? WayBillNORN { get; set; }

        [Column("WAYBILLSERIAL")]
        public virtual string? WayBillSerial { get; set; }

    }

    [Table("PDISCOVERYMINUTESVEHICLE")]
    public partial class PDiscoveryMinutesVehicle : PDiscoveryMinutesVehicleBase
    {
    }
}