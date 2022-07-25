

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class GPostTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GPOSTTYPE")]
    public partial class GPostType : GPostTypeBase
    {
    }
}