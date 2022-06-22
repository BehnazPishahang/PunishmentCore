

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class GMeasurementBasicUnitBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheGMeasurementBasicUnit")]
		public virtual List<Anu.BaseInfo.Types.MeasurementUnitType>? TheMeasurementUnitTypeList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GMEASUREMENTBASICUNIT")]
    public partial class GMeasurementBasicUnit : GMeasurementBasicUnitBase { }

    }


