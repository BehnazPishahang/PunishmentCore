

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBCaseStoreBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("ADDRESS")]
        public virtual string? Address { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("STORENAME")]
        public virtual string? StoreName { get; set; }

        [InverseProperty("ThePBCaseStore")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBCaseStoreUnit>? ThePBCaseStoreUnitList { get; set; }

    }

    [Table("PBCASESTORE")]
    public partial class PBCaseStore : PBCaseStoreBase
    {
    }
    }