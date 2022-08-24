using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Tablet
{
    public abstract class PAppVersionBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ALTERSCRIPT")]
        public virtual string? AlterScript { get; set; }

        [Unicode(false)]
        [Column("CHANGELIST")]
        public virtual string? ChangeList { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("FORCEDUPDATE")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? ForcedUpdate { get; set; }

        [Column("SERIALNO")]
        public virtual long? SerialNo { get; set; }

        [Unicode(false)]
        [Column("VERSIONDATETIME")]
        public virtual string? VersionDateTime { get; set; }

        [Unicode(false)]
        [Column("VERSIONNO")]
        public virtual string? VersionNo { get; set; }

        }

    [Table("PAPPVERSION")]
    public partial class PAppVersion : PAppVersionBase
    {
    }
    }