

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBCaseStoreUnitBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBCASESTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBCaseStore? ThePBCaseStore { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("PBCASESTOREUNIT")]
    public partial class PBCaseStoreUnit : PBCaseStoreUnitBase
    {
    }
}