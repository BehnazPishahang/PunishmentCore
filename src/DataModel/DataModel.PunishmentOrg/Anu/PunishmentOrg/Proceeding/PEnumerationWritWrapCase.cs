

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Proceeding
{
    public abstract class PEnumerationWritWrapCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PENUMERATIONWRITID")]
		public virtual Anu.PunishmentOrg.Proceeding.PEnumerationWrit? ThePEnumerationWrit { get; set; }

    }
    [Table("PENUMERATIONWRITWRAPCASE")]
    public partial class PEnumerationWritWrapCase : PEnumerationWritWrapCaseBase { }

    }


