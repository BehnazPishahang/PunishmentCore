

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class MeasurementUnitTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DIVIDEND")]
		public virtual decimal? dividend { get; set; }

		[Column("DIVISOR")]
		public virtual decimal? divisor { get; set; }

		[Column("ISBASEUNIT")]
		public virtual bool? IsBaseUnit { get; set; }

		[Column("OVERALLTYPE")]
		public virtual Rad.CMS.Enumerations.MeasurementUnitType? OverallType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("MEASUREMENTUNITTYPE")]
    public partial class MeasurementUnitType : MeasurementUnitTypeBase { }

    }


