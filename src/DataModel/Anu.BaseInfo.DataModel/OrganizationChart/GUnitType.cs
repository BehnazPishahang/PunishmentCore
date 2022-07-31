

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class GUnitTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("DESCRIPTION")]
        public virtual string? Description { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGUnitType")]
        public virtual List<Anu.BaseInfo.DataModel.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("GUNITTYPE")]
    public partial class GUnitType : GUnitTypeBase
    {
    }
    }