

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBProductCurrencyTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISPROHIBITEDGOODS")]
		public virtual Anu.Enumerations.YesNo? IsProhibitedGoods { get; set; }

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("NATIONALCODE")]
		public virtual string? NationalCode { get; set; }

		[Column("PRODUCTCURRENCY")]
		public virtual Anu.Enumerations.PunishmentOrg.PUProductCurrency? ProductCurrency { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentProductCurrency")]
		public virtual List<Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType>? TheChildProductCurrencyList { get; set; }

		[ForeignKey("GMEASUREMENTBASICUNITID")]
		public virtual Anu.BaseInfo.Types.GMeasurementBasicUnit? TheGMeasurementBasicUnit { get; set; }

		[ForeignKey("PARENTPRODUCTCURRENCYID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? TheParentProductCurrency { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBPRODUCTCURRENCYTYPE")]
    public partial class PBProductCurrencyType : PBProductCurrencyTypeBase { }

    }


