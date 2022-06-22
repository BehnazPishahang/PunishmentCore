

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.GeoInfo
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
		public virtual Anu.Enumerations.LocationType? LocationType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentLocation")]
		public virtual List<Anu.BaseInfo.GeoInfo.GeoLocation>? TheChildLocationsList { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("PARENTLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheParentLocation { get; set; }

    }
    [Table("GEOLOCATION")]
    public partial class GeoLocation : GeoLocationBase { }

    }


