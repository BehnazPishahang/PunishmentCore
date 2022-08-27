using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Destroyed
{
    public abstract class PDestroyedLicensePagesBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("FROMDATE")]
        public virtual string? FromDate { get; set; }

        [Unicode(false)]
        [Column("LICENSEID")]
        public virtual string? LicenseID { get; set; }

        [Column("NUMPAGES")]
        public virtual long? NumPages { get; set; }

        [Unicode(false)]
        [Column("PAGESTITLE")]
        public virtual string? PagesTitle { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [ForeignKey("PDESTROYEDLICENSEID")]
        public virtual Anu.PunishmentOrg.DataModel.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

        [Unicode(false)]
        [Column("TODATE")]
        public virtual string? ToDate { get; set; }

        }

    [Table("PDESTROYEDLICENSEPAGES")]
    public partial class PDestroyedLicensePages : PDestroyedLicensePagesBase
    {
    }
    }