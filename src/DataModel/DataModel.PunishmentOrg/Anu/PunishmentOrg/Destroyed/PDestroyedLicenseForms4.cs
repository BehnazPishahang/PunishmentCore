

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedLicenseForms4Base : PunishmentOrgEntity<string>
    {

		[ForeignKey("PDESTROYEDLICENSEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

		[ForeignKey("PDESTROYEDMINUTEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedMinute? ThePDestroyedMinute { get; set; }

    }
    [Table("PDESTROYEDLICENSEFORMS4")]
    public partial class PDestroyedLicenseForms4 : PDestroyedLicenseForms4Base { }

    }


