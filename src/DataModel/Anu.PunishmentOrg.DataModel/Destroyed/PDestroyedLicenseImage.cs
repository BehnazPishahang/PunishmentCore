using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedLicenseImageBase : PunishmentOrgEntity<string>
    {

        [Column("DOCIMAGE")]
        public virtual byte[]? DocImage { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PDESTROYEDLICENSEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

        }

    [Table("PDESTROYEDLICENSEIMAGE")]
    public partial class PDestroyedLicenseImage : PDestroyedLicenseImageBase
    {
    }
    }