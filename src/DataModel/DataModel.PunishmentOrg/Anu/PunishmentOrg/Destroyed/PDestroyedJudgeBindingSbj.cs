

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PDestroyedJudgeBindingSbjBase : PunishmentOrgEntity<string>
    {

		[Column("PENALTYAMOUNT")]
		public virtual decimal? PenaltyAmount { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("PBBINDINGSUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

		[ForeignKey("PDESTROYEDJUDGEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedJudge? ThePDestroyedJudge { get; set; }

    }
    [Table("PDESTROYEDJUDGEBINDINGSBJ")]
    public partial class PDestroyedJudgeBindingSbj : PDestroyedJudgeBindingSbjBase { }

    }


