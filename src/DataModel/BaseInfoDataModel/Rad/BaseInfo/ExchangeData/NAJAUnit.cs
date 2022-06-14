

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class NAJAUnitBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESC1")]
		public virtual string? Desc1 { get; set; }

		[Column("DESC2")]
		public virtual string? Desc2 { get; set; }

		[Column("DESC3")]
		public virtual string? Desc3 { get; set; }

		[Column("ISMECHANIZEREL")]
		public virtual Rad.CMS.Enumerations.YesNo? IsMechanizeRel { get; set; }

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("NAJACODE")]
		public virtual string? NAJACode { get; set; }

		[Column("RELATEDOTHERORG")]
		public virtual Rad.CMS.Enumerations.RelatedOtherOrg? RelatedOtherOrg { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentUnit")]
		public virtual List<Rad.BaseInfo.ExchangeData.NAJAUnit>? TheChildUnitList { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[InverseProperty("TheNAJAUnit")]
		public virtual List<Rad.BaseInfo.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Rad.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[ForeignKey("PARENTUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheParentUnit { get; set; }

		[Column("UNITNAME")]
		public virtual string? UnitName { get; set; }

		[Column("UNITTYPE")]
		public virtual Rad.CMS.Enumerations.NAJAUnitType? UnitType { get; set; }

    }
    [Table("NAJAUNIT")]
    public partial class NAJAUnit : NAJAUnitBase { }

    }


