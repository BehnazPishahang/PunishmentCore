﻿using System.ComponentModel.DataAnnotations.Schema;
using Anu.BaseInfo.DataModel.Security.Role;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GBAlarmTypeViewerBase : BaseInfoEntity<string>
    {

        [ForeignKey("BASEROLEID")]
        public virtual BaseRole? TheBaseRole { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("GBALARMTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.GBAlarmType? TheGBAlarmType { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [ForeignKey("GUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitType? TheGUnitType { get; set; }

        [Column("VIEWERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.AlarmViewerType? ViewerType { get; set; }

        }

    [Table("GBALARMTYPEVIEWER")]
    public partial class GBAlarmTypeViewer : GBAlarmTypeViewerBase
    {
    }
    }