

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class MeasurementUnitTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("EXCHANGERATE")]
        public virtual decimal? ExchangeRate { get; set; }

        [Column("OVERALLTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MeasurementUnitType? OverallType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("GMEASUREMENTBASICUNITID")]
        public virtual Anu.BaseInfo.DataModel.Types.GMeasurementBasicUnit? TheGMeasurementBasicUnit { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("MEASUREMENTUNITTYPE")]
    public partial class MeasurementUnitType : MeasurementUnitTypeBase
    {
    }
}