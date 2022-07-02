

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.GeoInfo
{
    public abstract class GeoLocationBase : BaseInfoEntity<string>
    {

        [Column("FULLLOCATIONNAME")]
        public virtual string? FullLocationName { get; set; }

        [Column("LOCATIONCODE")]
        public virtual string? LocationCode { get; set; }

        [Column("LOCATIONNAME")]
        public virtual string? LocationName { get; set; }

        [Column("LOCATIONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.LocationType? LocationType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheParentLocation")]
        public virtual List<Anu.BaseInfo.DataModel.GeoInfo.GeoLocation>? TheChildLocationsList { get; set; }

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("PARENTLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheParentLocation { get; set; }

    }

    [Table("GEOLOCATION")]
    public partial class GeoLocation : GeoLocationBase
    {
    }
}