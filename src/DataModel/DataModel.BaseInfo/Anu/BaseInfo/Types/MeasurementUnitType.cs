

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class MeasurementUnitTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("EXCHANGERATE")]
		public virtual decimal? ExchangeRate { get; set; }

		[Column("OVERALLTYPE")]
		public virtual Anu.Enumerations.MeasurementUnitType? OverallType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("GMEASUREMENTBASICUNITID")]
		public virtual Anu.BaseInfo.Types.GMeasurementBasicUnit? TheGMeasurementBasicUnit { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("MEASUREMENTUNITTYPE")]
    public partial class MeasurementUnitType : MeasurementUnitTypeBase { }

    }


