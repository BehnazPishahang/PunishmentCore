

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.OrganizationChart
{
    public abstract class UnitBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("SMSFARSINAME")]
		public virtual string? SMSFarsiName { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentUnit")]
		public virtual List<Anu.BaseInfo.OrganizationChart.Unit>? TheChildUnitsList { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[InverseProperty("TheUnit")]
		public virtual List<Anu.BaseInfo.OrganizationChart.GUnitImages>? TheGUnitImagesList { get; set; }

		[InverseProperty("TheUnit")]
		public virtual List<Anu.BaseInfo.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[ForeignKey("PARENTUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheParentUnit { get; set; }

		[Column("UNITNAME")]
		public virtual string? UnitName { get; set; }

		[Column("UNITNO")]
		public virtual string? UnitNo { get; set; }

    }
    [Table("UNIT")]
    public partial class Unit : UnitBase { }

    }


