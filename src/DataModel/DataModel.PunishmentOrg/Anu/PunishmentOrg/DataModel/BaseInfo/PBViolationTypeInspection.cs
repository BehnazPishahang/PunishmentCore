

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBViolationTypeInspectionBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBINSPECTIONVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBInspectionViolationType? ThePBInspectionViolationType { get; set; }

        [ForeignKey("PBVIOLATIONTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

    }

    [Table("PBVIOLATIONTYPEINSPECTION")]
    public partial class PBViolationTypeInspection : PBViolationTypeInspectionBase
    {
    }
}