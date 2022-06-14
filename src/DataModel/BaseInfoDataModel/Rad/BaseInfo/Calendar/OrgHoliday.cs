

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Calendar
{
    public abstract class OrgHolidayBase : BaseInfoEntity<string>
    {

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("HOLIDAYNAME")]
		public virtual string? HolidayName { get; set; }

		[Column("HOLIDAYTYPE")]
		public virtual Rad.CMS.Enumerations.HolidayKind? HolidayType { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("GDATEID")]
		public virtual Rad.BaseInfo.Calendar.GDate? TheGDate { get; set; }

    }
    [Table("ORGHOLIDAY")]
    public partial class OrgHoliday : OrgHolidayBase { }

    }


