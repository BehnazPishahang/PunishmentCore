

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Alarm
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
		public virtual List<Anu.Alarm.GAlarmViewer>? TheGAlarmViewerList { get; set; }

		[ForeignKey("GBALARMTYPEID")]
		public virtual Anu.BaseInfo.Types.GBAlarmType? TheGBAlarmType { get; set; }

		[ForeignKey("INNERORGCAUSESID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheInnerOrgCauses { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("OUTTERORGCAUSESID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheOutterOrgCauses { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GALARM")]
    public partial class GAlarm : GAlarmBase { }

    }


