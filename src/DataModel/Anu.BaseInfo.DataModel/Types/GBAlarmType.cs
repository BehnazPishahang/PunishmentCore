

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GBAlarmTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGBAlarmType")]
        public virtual List<Anu.BaseInfo.DataModel.Types.GBAlarmTypeViewer>? TheGBAlarmTypeViewerList { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GBALARMTYPE")]
    public partial class GBAlarmType : GBAlarmTypeBase
    {
    }
}