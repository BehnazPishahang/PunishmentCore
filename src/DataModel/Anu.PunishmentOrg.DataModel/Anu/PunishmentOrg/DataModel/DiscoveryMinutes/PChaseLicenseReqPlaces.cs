

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqPlacesBase : PunishmentOrgEntity<string>
    {

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

        [Column("PLACEADDRESS")]
        public virtual string? PlaceAddress { get; set; }

        [Column("PLACEBENEFICIARY")]
        public virtual string? PlaceBeneficiary { get; set; }

        [Column("PLACELICENSENUMBER")]
        public virtual string? PlacelicenseNumber { get; set; }

        [Column("PLACEOWNER")]
        public virtual string? PlaceOwner { get; set; }

        [Column("PLACEPHONENUM")]
        public virtual string? PlacePhoneNum { get; set; }

        [Column("PLACEPLAQUE")]
        public virtual string? PlacePlaque { get; set; }

        [Column("PLACEPOSTCODE")]
        public virtual string? PlacePostCode { get; set; }

        [Column("PLACEUNITNAME")]
        public virtual string? PlaceUnitName { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [Column("USERLOCATION")]
        public virtual string? UserLocation { get; set; }

    }

    [Table("PCHASELICENSEREQPLACES")]
    public partial class PChaseLicenseReqPlaces : PChaseLicenseReqPlacesBase
    {
    }
}