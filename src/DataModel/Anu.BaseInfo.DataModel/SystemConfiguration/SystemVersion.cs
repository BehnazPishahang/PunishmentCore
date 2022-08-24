using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.SystemConfiguration
{
    public abstract class SystemVersionBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("SYSTEMNAME")]
        public virtual string? SystemName { get; set; }

        [Unicode(false)]
        [Column("VERSIONNO")]
        public virtual string? VersionNo { get; set; }

        }

    [Table("SYSTEMVERSION")]
    public partial class SystemVersion : SystemVersionBase
    {
    }
    }