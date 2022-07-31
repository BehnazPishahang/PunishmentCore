

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.DiscoveryMinutes
{
    public abstract class PChaseLicenseReqPlacesBase : PunishmentOrgEntity<string>
    {

        [Column("OWNERSHIPTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

        [Unicode(false)]
        [Column("PLACEADDRESS")]
        public virtual string? PlaceAddress { get; set; }

        [Unicode(false)]
        [Column("PLACEBENEFICIARY")]
        public virtual string? PlaceBeneficiary { get; set; }

        [Unicode(false)]
        [Column("PLACELICENSENUMBER")]
        public virtual string? PlacelicenseNumber { get; set; }

        [Unicode(false)]
        [Column("PLACEOWNER")]
        public virtual string? PlaceOwner { get; set; }

        [Unicode(false)]
        [Column("PLACEPHONENUM")]
        public virtual string? PlacePhoneNum { get; set; }

        [Unicode(false)]
        [Column("PLACEPLAQUE")]
        public virtual string? PlacePlaque { get; set; }

        [Unicode(false)]
        [Column("PLACEPOSTCODE")]
        public virtual string? PlacePostCode { get; set; }

        [Unicode(false)]
        [Column("PLACEUNITNAME")]
        public virtual string? PlaceUnitName { get; set; }

        [ForeignKey("PCHASELICENSEREQID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PChaseLicenseReq? ThePChaseLicenseReq { get; set; }

        [Unicode(false)]
        [Column("USERLOCATION")]
        public virtual string? UserLocation { get; set; }

    }

    [Table("PCHASELICENSEREQPLACES")]
    public partial class PChaseLicenseReqPlaces : PChaseLicenseReqPlacesBase
    {
    }
    }