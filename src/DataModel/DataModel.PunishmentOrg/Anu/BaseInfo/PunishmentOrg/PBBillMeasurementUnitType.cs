

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBBillMeasurementUnitTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ORGCODE")]
		public virtual string? OrgCode { get; set; }

		[Column("ORGID")]
		public virtual long? OrgID { get; set; }

		[Column("OVERALLTYPE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.MeasurementUnitType? OverallType { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBBILLMEASUREMENTUNITTYPE")]
    public partial class PBBillMeasurementUnitType : PBBillMeasurementUnitTypeBase { }

    }


