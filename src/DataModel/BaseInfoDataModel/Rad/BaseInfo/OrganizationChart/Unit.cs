

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class UnitBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("PAYMENTID")]
		public virtual string? PaymentID { get; set; }

		[Column("SMSENGLISHNAME")]
		public virtual string? SMSEnglishName { get; set; }

		[Column("SMSFARSINAME")]
		public virtual string? SMSFarsiName { get; set; }

		[Column("SSAACODE")]
		public virtual string? SSAACode { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("STATEINJUDICIARY")]
		public virtual string? StateInJudiciary { get; set; }

		[InverseProperty("TheParentUnit")]
		public virtual List<Rad.BaseInfo.OrganizationChart.Unit>? TheChildUnitList { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[InverseProperty("TheUnit")]
		public virtual List<Rad.BaseInfo.OrganizationChart.GUnitImages>? TheGUnitImagesList { get; set; }

		[InverseProperty("TheUnit")]
		public virtual List<Rad.BaseInfo.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Rad.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[ForeignKey("PARENTUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheParentUnit { get; set; }

		[Column("UNITNAME")]
		public virtual string? UnitName { get; set; }

		[Column("UNITNO")]
		public virtual string? UnitNo { get; set; }

    }
    [Table("UNIT")]
    public partial class Unit : UnitBase { }

    }


