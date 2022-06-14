

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Terminate
{
    public abstract class PJudgmentBindingSubjectBase : PunishmentOrgEntity<string>
    {

		[Column("PENALTYAMOUNT")]
		public virtual decimal? PenaltyAmount { get; set; }

		[Column("PENALTYGETTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PenaltyGetType? PenaltyGetType { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBBINDINGSUBJECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

		[ForeignKey("PJUDGMENTID")]
		public virtual Anu.PunishmentOrg.Terminate.PJudgment? ThePJudgment { get; set; }

		[InverseProperty("ThePJudgmentBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubjectPrsn>? ThePJudgmentBindingSubjectPrsnList { get; set; }

		[InverseProperty("ThePJudgmentBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

		[InverseProperty("ThePJudgmentBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindingSubTriple>? ThePJudgmentBindingSubTripleList { get; set; }

		[InverseProperty("ThePJudgmentBindingSubject")]
		public virtual List<Anu.PunishmentOrg.Terminate.PJudgmentBindSbjProduct>? ThePJudgmentBindSbjProductList { get; set; }

    }
    [Table("PJUDGMENTBINDINGSUBJECT")]
    public partial class PJudgmentBindingSubject : PJudgmentBindingSubjectBase { }

    }


