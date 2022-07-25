

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Alarm
{
    public abstract class GAlarmBase : BaseInfoEntity<string>
    {

        [Column("ALARMTEXT")]
        public virtual string? AlarmText { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("NO")]
        public virtual string? No { get; set; }

        [Column("RELATEDDOCID")]
        public virtual string? RelatedDocId { get; set; }

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