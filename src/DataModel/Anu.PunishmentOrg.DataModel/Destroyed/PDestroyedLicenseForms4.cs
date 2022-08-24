using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedLicenseForms4Base : PunishmentOrgEntity<string>
    {

        [ForeignKey("PDESTROYEDLICENSEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

        [ForeignKey("PDESTROYEDMINUTEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

        }

    [Table("PDESTROYEDLICENSEFORMS4")]
    public partial class PDestroyedLicenseForms4 : PDestroyedLicenseForms4Base
    {
    }
    }