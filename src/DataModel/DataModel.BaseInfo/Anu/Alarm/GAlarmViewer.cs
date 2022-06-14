

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.Alarm
{
    public abstract class GAlarmViewerBase : BaseInfoEntity<string>
    {

		[Column("ACTIVEDATETIME")]
		public virtual string? ActiveDateTime { get; set; }

		[Column("SEENDATETIME")]
		public virtual string? SeenDateTime { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("BASEROLEID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GALARMID")]
		public virtual Anu.Alarm.GAlarm? TheGAlarm { get; set; }

		[ForeignKey("GFESUSERACCESSID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }
    [Table("GALARMVIEWER")]
    public partial class GAlarmViewer : GAlarmViewerBase { }

    }


