

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GMeasurementBasicUnitBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGMeasurementBasicUnit")]
        public virtual List<Anu.BaseInfo.DataModel.Types.MeasurementUnitType>? TheMeasurementUnitTypeList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GMEASUREMENTBASICUNIT")]
    public partial class GMeasurementBasicUnit : GMeasurementBasicUnitBase
    {
    }
    }