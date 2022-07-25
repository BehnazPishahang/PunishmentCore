

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Alarm
{
    public abstract class GAlarmViewerBase : BaseInfoEntity<string>
    {

        [Column("ACTIVEDATETIME")]
        public virtual string? ActiveDateTime { get; set; }

        [Column("SEENDATETIME")]
        public virtual string? SeenDateTime { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("BASEROLEID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheBaseRole { get; set; }

        [ForeignKey("CMSORGANIZATIONID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

        [ForeignKey("CMSUSERROLETYPEID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSUserRoleType? TheCMSUserRoleType { get; set; }

        [ForeignKey("GALARMID")]
        public virtual Anu.BaseInfo.DataModel.Alarm.GAlarm? TheGAlarm { get; set; }

        [ForeignKey("GFESUSERACCESSID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess? TheGFESUserAccess { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("REGISTERUSERHISTORYID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

    }

    [Table("GALARMVIEWER")]
    public partial class GAlarmViewer : GAlarmViewerBase
    {
    }
}