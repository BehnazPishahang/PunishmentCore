

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Proceeding
{
    public abstract class PEnumerationWritCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PENUMERATIONWRITID")]
		public virtual Anu.PunishmentOrg.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

    }
    [Table("PENUMERATIONWRITCASE")]
    public partial class PEnumerationWritCase : PEnumerationWritCaseBase { }

    }


