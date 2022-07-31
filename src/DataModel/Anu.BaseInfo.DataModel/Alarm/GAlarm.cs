

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Alarm
{
    public abstract class GAlarmBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("ALARMTEXT")]
        public virtual string? AlarmText { get; set; }

        [Unicode(false)]
        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Unicode(false)]
        [Column("NO")]
        public virtual string? No { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

        [Unicode(false)]
        [Column("RELATEDDOCNO")]
        public virtual string? RelatedDocNo { get; set; }

        [InverseProperty("TheGAlarm")]
        public virtual List<Anu.BaseInfo.DataModel.Alarm.GAlarmViewer>? TheGAlarmViewerList { get; set; }

        [ForeignKey("GBALARMTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GBAlarmType? TheGBAlarmType { get; set; }

        [ForeignKey("INNERORGCAUSESID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheInnerOrgCauses { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("OUTTERORGCAUSESID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheOutterOrgCauses { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

    }

    [Table("GALARM")]
    public partial class GAlarm : GAlarmBase
    {
    }
    }