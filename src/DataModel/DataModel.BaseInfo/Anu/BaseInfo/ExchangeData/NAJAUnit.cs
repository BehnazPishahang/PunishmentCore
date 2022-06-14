

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.ExchangeData
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

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("NAJACODE")]
		public virtual string? NAJACode { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentUnit")]
		public virtual List<Anu.BaseInfo.ExchangeData.NAJAUnit>? TheChildUnitList { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[InverseProperty("TheNAJAUnit")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>? TheGFESUserAccessList { get; set; }

		[InverseProperty("TheNAJAUnit")]
		public virtual List<Anu.BaseInfo.ExchangeData.GUnitRelatedNajaUnit>? TheGUnitRelatedNajaUnitList { get; set; }

		[ForeignKey("PARENTUNITID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheParentUnit { get; set; }

		[Column("UNITNAME")]
		public virtual string? UnitName { get; set; }

    }
    [Table("NAJAUNIT")]
    public partial class NAJAUnit : NAJAUnitBase { }

    }


