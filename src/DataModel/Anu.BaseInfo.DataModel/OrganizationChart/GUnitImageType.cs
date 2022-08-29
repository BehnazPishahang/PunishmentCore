using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class GUnitImageTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        }

    [Table("GUNITIMAGETYPE")]
    public partial class GUnitImageType : GUnitImageTypeBase
    {
    }
    }