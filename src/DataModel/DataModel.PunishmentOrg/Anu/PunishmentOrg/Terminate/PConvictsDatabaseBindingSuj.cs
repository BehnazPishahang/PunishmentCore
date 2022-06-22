

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate
{
    public abstract class PConvictsDatabaseBindingSujBase : PunishmentOrgEntity<string>
    {

		[Column("ENDPENALTYDATE")]
		public virtual string? EndPenaltyDate { get; set; }

		[Column("EXECUTIVESTATUS")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUExecutiveStatus? ExecutiveStatus { get; set; }

		[Column("PENALTYAMOUNT")]
		public virtual decimal? PenaltyAmount { get; set; }

		[Column("PENALTYGETTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PenaltyGetType? PenaltyGetType { get; set; }

		[Column("STARTPENALTYDATE")]
		public virtual string? StartPenaltyDate { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBBINDINGSUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

		[ForeignKey("PCONVICTSDATABASEJUDGEID")]
		public virtual Anu.PunishmentOrg.Terminate.PConvictsDatabaseJudge? ThePConvictsDatabaseJudge { get; set; }

    }
    [Table("PCONVICTSDATABASEBINDINGSUJ")]
    public partial class PConvictsDatabaseBindingSuj : PConvictsDatabaseBindingSujBase { }

    }


