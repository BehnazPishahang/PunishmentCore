

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBBillGeoLocationBase : PunishmentOrgEntity<string>
    {

		[Column("LOCATIONCODE")]
		public virtual string? LocationCode { get; set; }

		[Column("LOCATIONNAME")]
		public virtual string? LocationName { get; set; }

		[Column("LOCATIONTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.LocationType? LocationType { get; set; }

		[Column("ORGCODE")]
		public virtual string? OrgCode { get; set; }

		[Column("ORGID")]
		public virtual long? OrgID { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

    }
    [Table("PBBILLGEOLOCATION")]
    public partial class PBBillGeoLocation : PBBillGeoLocationBase { }

    }


