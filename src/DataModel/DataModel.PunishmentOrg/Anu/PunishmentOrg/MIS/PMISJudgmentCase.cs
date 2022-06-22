

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISJudgmentCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PMISJUDGMENTID")]
		public virtual Anu.PunishmentOrg.MIS.PMISJudgment? ThePMISJudgment { get; set; }

    }
    [Table("PMISJUDGMENTCASE")]
    public partial class PMISJudgmentCase : PMISJudgmentCaseBase { }

    }


