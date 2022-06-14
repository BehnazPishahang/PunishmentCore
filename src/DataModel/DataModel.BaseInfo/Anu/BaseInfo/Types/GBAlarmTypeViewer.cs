

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.Types
{
    public abstract class GBAlarmTypeViewerBase : BaseInfoEntity<string>
    {

		[ForeignKey("BASEROLEID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheBaseRole { get; set; }

		[ForeignKey("CMSUSERROLETYPEID")]
		public virtual Anu.BaseInfo.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

		[ForeignKey("GBALARMTYPEID")]
		public virtual Anu.BaseInfo.Types.GBAlarmType? TheGBAlarmType { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[Column("VIEWERTYPE")]
		public virtual Anu.Enumerations.AlarmViewerType? ViewerType { get; set; }

    }
    [Table("GBALARMTYPEVIEWER")]
    public partial class GBAlarmTypeViewer : GBAlarmTypeViewerBase { }

    }


