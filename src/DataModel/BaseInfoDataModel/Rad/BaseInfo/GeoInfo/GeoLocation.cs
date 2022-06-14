

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GeoInfo
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
		public virtual Rad.CMS.Enumerations.LocationType? LocationType { get; set; }

		[Column("SHOWLOCATIONNAME")]
		public virtual string? ShowLocationName { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GCOUNTRYDIVISIONKINDID")]
		public virtual Rad.BaseInfo.GeoInfo.GCountryDivisionKind? TheGCountryDivisionKind { get; set; }

		[ForeignKey("PARENTLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheParentLocation { get; set; }

    }
    [Table("GEOLOCATION")]
    public partial class GeoLocation : GeoLocationBase { }

    }


