

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class NewspaperGeoLocationBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LOCATIONTYPE")]
		public virtual Rad.CMS.Enumerations.LocationType? LocationType { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("NEWSPAPERGEOLOCATION")]
    public partial class NewspaperGeoLocation : NewspaperGeoLocationBase { }

    }


