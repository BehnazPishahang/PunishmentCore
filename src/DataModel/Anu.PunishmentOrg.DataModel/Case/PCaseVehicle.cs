using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseVehicleBase : PunishmentOrgEntity<string>
    {

        [Column("ARRESTEDVEHICLE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ArrestedVehicle { get; set; }

        [Unicode(false)]
        [Column("CHASSISNUMBER")]
        public virtual string? ChassisNumber { get; set; }

        [Unicode(false)]
        [Column("CHASSISNUMBERRN")]
        public virtual string? ChassisNumberRN { get; set; }

        [Unicode(false)]
        [Column("COLOR")]
        public virtual string? Color { get; set; }

        [Unicode(false)]
        [Column("DRIVERFAMILY")]
        public virtual string? DriverFamily { get; set; }

        [Column("DRIVERFULLNAMERN")]
        public virtual Anu.PunishmentOrg.Enumerations.DriverFullName? DriverFullNameRN { get; set; }

        [Unicode(false)]
        [Column("DRIVERNAME")]
        public virtual string? DriverName { get; set; }

        [Unicode(false)]
        [Column("IRANNUMBER")]
        public virtual string? IranNumber { get; set; }

        [Column("ISSUEPARKBILLREG")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IssueParkBillReg { get; set; }

        [Unicode(false)]
        [Column("MODEL")]
        public virtual string? Model { get; set; }

        [Unicode(false)]
        [Column("MOTORNUMBER")]
        public virtual string? MotorNumber { get; set; }

        [Unicode(false)]
        [Column("MOTORNUMBERRN")]
        public virtual string? MotorNumberRN { get; set; }

        [Unicode(false)]
        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Column("OTHERINFORN")]
        public virtual Anu.PunishmentOrg.Enumerations.OtherInfo? OtherInfoRN { get; set; }

        [Unicode(false)]
        [Column("OWNERFAMILY")]
        public virtual string? OwnerFamily { get; set; }

        [Unicode(false)]
        [Column("OWNERFULLNAMERN")]
        public virtual string? OwnerFullNameRN { get; set; }

        [Unicode(false)]
        [Column("OWNERNAME")]
        public virtual string? OwnerName { get; set; }

        [Unicode(false)]
        [Column("PARKFICHENO")]
        public virtual string? ParkFicheNo { get; set; }

        [Unicode(false)]
        [Column("PARKINGNAME")]
        public virtual string? ParkingName { get; set; }

        [Unicode(false)]
        [Column("PLAQUENUMBER")]
        public virtual string? PlaqueNumber { get; set; }

        [Column("PLAQUENUMBERRN")]
        public virtual Anu.PunishmentOrg.Enumerations.PlaqueNumber? PlaqueNumberRN { get; set; }

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

        [Column("REGINWAYBILL")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? RegInWaybill { get; set; }

        [Column("REGINWAYBILLRN")]
        public virtual Anu.PunishmentOrg.Enumerations.RegInWaybill? RegInWaybillRN { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCaseVehicle")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseVehiclePerson>? ThePCaseVehiclePersonList { get; set; }

        [Column("VEHICLESTATE")]
        public virtual Anu.PunishmentOrg.Enumerations.VehicleState? VehicleState { get; set; }

        [Column("VEHICLETYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.VehicleType? VehicleType { get; set; }

        [Unicode(false)]
        [Column("WAYBILLNO")]
        public virtual string? WayBillNO { get; set; }

        [Column("WAYBILLNORN")]
        public virtual Anu.PunishmentOrg.Enumerations.WayBillNO? WayBillNORN { get; set; }

        }

    [Table("PCASEVEHICLE")]
    public partial class PCaseVehicle : PCaseVehicleBase
    {
    }
    }