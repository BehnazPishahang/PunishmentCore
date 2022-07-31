

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBBillGeoLocationBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("LOCATIONCODE")]
        public virtual string? LocationCode { get; set; }

        [Unicode(false)]
        [Column("LOCATIONNAME")]
        public virtual string? LocationName { get; set; }

        [Column("LOCATIONTYPE")]
        public virtual Anu.BaseInfo.Enumerations.LocationType? LocationType { get; set; }

        [Unicode(false)]
        [Column("ORGCODE")]
        public virtual string? OrgCode { get; set; }

        [Column("ORGID")]
        public virtual long? OrgID { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

    }

    [Table("PBBILLGEOLOCATION")]
    public partial class PBBillGeoLocation : PBBillGeoLocationBase
    {
    }
    }