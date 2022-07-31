

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Terminate
{
    public abstract class PJudgmentBindingSubjectBase : PunishmentOrgEntity<string>
    {

        [Column("PENALTYAMOUNT")]
        public virtual decimal? PenaltyAmount { get; set; }

        [Column("PENALTYGETTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PenaltyGetType? PenaltyGetType { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBBINDINGSUBJECTTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBindingSubjectType? ThePBBindingSubjectType { get; set; }

        [ForeignKey("PJUDGMENTID")]
        public virtual Anu.PunishmentOrg.DataModel.Terminate.PJudgment? ThePJudgment { get; set; }

        [InverseProperty("ThePJudgmentBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubjectPrsn>? ThePJudgmentBindingSubjectPrsnList { get; set; }

        [InverseProperty("ThePJudgmentBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubjectRpl>? ThePJudgmentBindingSubjectRplList { get; set; }

        [InverseProperty("ThePJudgmentBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindingSubTriple>? ThePJudgmentBindingSubTripleList { get; set; }

        [InverseProperty("ThePJudgmentBindingSubject")]
        public virtual List<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentBindSbjProduct>? ThePJudgmentBindSbjProductList { get; set; }

    }

    [Table("PJUDGMENTBINDINGSUBJECT")]
    public partial class PJudgmentBindingSubject : PJudgmentBindingSubjectBase
    {
    }
    }