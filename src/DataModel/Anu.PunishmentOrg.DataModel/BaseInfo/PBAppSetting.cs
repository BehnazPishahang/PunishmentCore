using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBAppSettingBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("KEY")]
        public virtual string? Key { get; set; }

        [Unicode(false)]
        [Column("VALUE")]
        public virtual string? Value { get; set; }

        }

    [Table("PBAPPSETTING")]
    public partial class PBAppSetting : PBAppSettingBase
    {
    }
    }