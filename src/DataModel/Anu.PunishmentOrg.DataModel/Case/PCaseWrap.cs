using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseWrapBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("MAINCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheMainCase { get; set; }

        [ForeignKey("WRAPCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? TheWrapCase { get; set; }

        }

    [Table("PCASEWRAP")]
    public partial class PCaseWrap : PCaseWrapBase
    {
    }
    }