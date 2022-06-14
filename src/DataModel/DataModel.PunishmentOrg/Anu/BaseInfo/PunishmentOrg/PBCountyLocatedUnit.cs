

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBCountyLocatedUnitBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBCOUNTYLOCATEDUNIT")]
    public partial class PBCountyLocatedUnit : PBCountyLocatedUnitBase { }

    }


