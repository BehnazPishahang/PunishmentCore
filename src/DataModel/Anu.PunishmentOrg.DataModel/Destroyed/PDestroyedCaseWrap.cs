using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedCaseWrapBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CMSNO")]
        public virtual string? CMSNo { get; set; }

        [Unicode(false)]
        [Column("ID")]
        public virtual string? Id { get; set; }

        [Unicode(false)]
        [Column("MANUALNO")]
        public virtual string? ManualNo { get; set; }

        [ForeignKey("PDESTROYEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedCase? ThePDestroyedCase { get; set; }

        [ForeignKey("WRAPEDCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheWrapedCase { get; set; }

        }

    [Table("PDESTROYEDCASEWRAP")]
    public partial class PDestroyedCaseWrap : PDestroyedCaseWrapBase
    {
    }
    }