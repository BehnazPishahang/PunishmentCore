

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentViolatorBase : PunishmentOrgEntity<string>
    {

		[Column("PRESENTSTATE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUJudgementViolatorP? PresentState { get; set; }

		[ForeignKey("PCASEPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? ThePCasePerson { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

    }
    [Table("PJUDGMENTVIOLATOR")]
    public partial class PJudgmentViolator : PJudgmentViolatorBase { }

    }


