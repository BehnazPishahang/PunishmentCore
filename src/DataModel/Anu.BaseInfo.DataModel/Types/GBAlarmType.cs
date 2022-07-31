

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GBAlarmTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGBAlarmType")]
        public virtual List<Anu.BaseInfo.DataModel.Types.GBAlarmTypeViewer>? TheGBAlarmTypeViewerList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GBALARMTYPE")]
    public partial class GBAlarmType : GBAlarmTypeBase
    {
    }
    }