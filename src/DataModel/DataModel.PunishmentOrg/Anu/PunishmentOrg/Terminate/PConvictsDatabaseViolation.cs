

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PConvictsDatabaseViolationBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBJUDGESUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBJudgeSubjectType? ThePBJudgeSubjectType { get; set; }

		[ForeignKey("PBVIOLATIONTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBViolationType? ThePBViolationType { get; set; }

		[ForeignKey("PCONVICTSDATABASEJUDGEID")]
		public virtual Anu.PunishmentOrg.Terminate.PConvictsDatabaseJudge? ThePConvictsDatabaseJudge { get; set; }

    }
    [Table("PCONVICTSDATABASEVIOLATION")]
    public partial class PConvictsDatabaseViolation : PConvictsDatabaseViolationBase { }

    }


