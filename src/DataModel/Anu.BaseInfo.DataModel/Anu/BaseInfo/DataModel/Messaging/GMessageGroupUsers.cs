

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Messaging
{
    public abstract class GMessageGroupUsersBase : BaseInfoEntity<string>
    {

        [ForeignKey("CLIENTUNITID")]
        public virtual Anu.BaseInfo.DataModel.SystemConfiguration.CMSOrganization? TheClientUnit { get; set; }

        [ForeignKey("CLIENTUSERID")]
        public virtual Anu.BaseInfo.DataModel.Security.CMSUser.CMSUser? TheClientUser { get; set; }

        [ForeignKey("GMESSAGEGROUPID")]
        public virtual Anu.BaseInfo.DataModel.Messaging.GMessageGroup? TheGMessageGroup { get; set; }

    }

    [Table("GMESSAGEGROUPUSERS")]
    public partial class GMessageGroupUsers : GMessageGroupUsersBase
    {
    }
}