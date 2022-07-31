

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBInspectionViolationTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CASESUBJECT")]
        public virtual Anu.PunishmentOrg.Enumerations.PUViolationType? CaseSubject { get; set; }

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("ThePBInspectionViolationType")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationTypeInspection>? ThePBViolationTypeInspectionList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBINSPECTIONVIOLATIONTYPE")]
    public partial class PBInspectionViolationType : PBInspectionViolationTypeBase
    {
    }
    }