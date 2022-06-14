

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedLicenseImageBase : PunishmentOrgEntity<string>
    {

		[Column("DOCIMAGE")]
		public virtual byte[]? DocImage { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PDESTROYEDLICENSEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

    }
    [Table("PDESTROYEDLICENSEIMAGE")]
    public partial class PDestroyedLicenseImage : PDestroyedLicenseImageBase { }

    }


