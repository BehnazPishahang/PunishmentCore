

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.Tablet
{
    public abstract class PAppVersionBase : PunishmentOrgEntity<string>
    {

        [Column("ALTERSCRIPT")]
        public virtual string? AlterScript { get; set; }

        [Column("CHANGELIST")]
        public virtual string? ChangeList { get; set; }

        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("FORCEDUPDATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ForcedUpdate { get; set; }

        [Column("SERIALNO")]
        public virtual long? SerialNo { get; set; }

        [Column("VERSIONDATETIME")]
        public virtual string? VersionDateTime { get; set; }

        [Column("VERSIONNO")]
        public virtual string? VersionNo { get; set; }

    }

    [Table("PAPPVERSION")]
    public partial class PAppVersion : PAppVersionBase
    {
    }
}