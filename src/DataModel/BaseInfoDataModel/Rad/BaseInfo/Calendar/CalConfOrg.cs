

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Calendar
{
    public abstract class CalConfOrgBase : BaseInfoEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("CALENDARCONFID")]
		public virtual Rad.BaseInfo.Calendar.CalendarConf? TheCalendarConf { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

    }
    [Table("CALCONFORG")]
    public partial class CalConfOrg : CalConfOrgBase { }

    }


