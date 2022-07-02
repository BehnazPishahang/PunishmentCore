

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBCountyLocatedUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("GEOLOCATIONID")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBCOUNTYLOCATEDUNIT")]
    public partial class PBCountyLocatedUnit : PBCountyLocatedUnitBase
    {
    }
}