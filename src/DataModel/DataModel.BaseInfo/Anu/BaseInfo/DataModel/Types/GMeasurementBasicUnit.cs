

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GMeasurementBasicUnitBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGMeasurementBasicUnit")]
        public virtual List<Anu.BaseInfo.DataModel.Types.MeasurementUnitType>? TheMeasurementUnitTypeList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GMEASUREMENTBASICUNIT")]
    public partial class GMeasurementBasicUnit : GMeasurementBasicUnitBase
    {
    }
}