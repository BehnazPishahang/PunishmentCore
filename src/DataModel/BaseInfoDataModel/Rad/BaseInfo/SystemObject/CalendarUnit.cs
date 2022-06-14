

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemObject
{
    public abstract class CalendarUnitBase : BaseInfoEntity<string>
    {

		[ForeignKey("CALENDARID")]
		public virtual Rad.BaseInfo.SystemObject.Calendar? TheCalendar { get; set; }

		[ForeignKey("UNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("CALENDARUNIT")]
    public partial class CalendarUnit : CalendarUnitBase { }

    }


