

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GOffLineServiceTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("SYSTEMOBJECTID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.SystemObject? TheSystemObject { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GOFFLINESERVICETYPE")]
    public partial class GOffLineServiceType : GOffLineServiceTypeBase
    {
    }
}