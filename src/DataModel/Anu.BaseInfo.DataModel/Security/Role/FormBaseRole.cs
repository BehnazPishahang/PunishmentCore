

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Security.Role
{
    public abstract class FormBaseRoleBase : BaseInfoEntity<string>
    {

        [ForeignKey("BASEROLEID")]
        public virtual Anu.BaseInfo.DataModel.Security.Role.BaseRole? TheBaseRole { get; set; }

        [ForeignKey("SYSTEMFORMID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemForm? TheSystemForm { get; set; }

    }

    [Table("FORMBASEROLE")]
    public partial class FormBaseRole : FormBaseRoleBase
    {
    }
}