

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class VatInfoBase : BaseInfoEntity<string>
    {

		[Column("FAMILY")]
		public virtual string? Family { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("NATIONALNO")]
		public virtual string? NationalNo { get; set; }

		[Column("TAXACCOUNTNO")]
		public virtual string? TaxAccountNo { get; set; }

		[Column("TAXOSTAN")]
		public virtual string? TaxOstan { get; set; }

		[Column("TAXPERCENT")]
		public virtual decimal? TaxPercent { get; set; }

		[Column("TAXSHEBANO")]
		public virtual string? TaxShebaNo { get; set; }

		[Column("TAXUNITCODE")]
		public virtual string? TaxUnitCode { get; set; }

		[Column("TAXUNITNAME")]
		public virtual string? TaxUnitName { get; set; }

		[Column("TOLLACCOUNTNO")]
		public virtual string? TollAccountNo { get; set; }

		[Column("TOLLOSTAN")]
		public virtual string? TollOstan { get; set; }

		[Column("TOLLPERCENT")]
		public virtual decimal? TollPercent { get; set; }

		[Column("TOLLSHEBANO")]
		public virtual string? TollShebaNo { get; set; }

    }
    [Table("VATINFO")]
    public partial class VatInfo : VatInfoBase { }

    }


