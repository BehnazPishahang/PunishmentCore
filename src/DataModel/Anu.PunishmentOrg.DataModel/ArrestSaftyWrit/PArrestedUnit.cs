using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.ArrestSaftyWrit
{
    public abstract class PArrestedUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PARRESTEDID")]
        public virtual Anu.PunishmentOrg.DataModel.ArrestSaftyWrit.PArrested? ThePArrested { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        }

    [Table("PARRESTEDUNIT")]
    public partial class PArrestedUnit : PArrestedUnitBase
    {
    }
    }