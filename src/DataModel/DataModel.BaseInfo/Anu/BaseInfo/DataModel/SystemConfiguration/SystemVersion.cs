

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class SystemVersionBase : BaseInfoEntity<string>
    {

        [Column("SYSTEMNAME")]
        public virtual string? SystemName { get; set; }

        [Column("VERSIONNO")]
        public virtual string? VersionNo { get; set; }

    }

    [Table("SYSTEMVERSION")]
    public partial class SystemVersion : SystemVersionBase
    {
    }
}