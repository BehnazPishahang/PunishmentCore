

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Calendar
{
    public abstract class CalendarConfBase : BaseInfoEntity<string>
    {

		[Column("CMSCODE")]
		public virtual string? CMScode { get; set; }

		[Column("CMSNAME")]
		public virtual string? CMSname { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? STATE { get; set; }

		[InverseProperty("TheCalendarConf")]
		public virtual List<Rad.BaseInfo.Calendar.CalConfOrg>? TheCalConfOrgList { get; set; }

		[InverseProperty("TheCalendarConf")]
		public virtual List<Rad.BaseInfo.Calendar.WorkTime>? TheWorkTimeList { get; set; }

    }
    [Table("CALENDARCONF")]
    public partial class CalendarConf : CalendarConfBase { }

    }


