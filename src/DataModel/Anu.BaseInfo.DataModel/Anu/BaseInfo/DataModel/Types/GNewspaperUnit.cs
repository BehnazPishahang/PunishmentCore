

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.Types
{
    public abstract class GNewspaperUnitBase : BaseInfoEntity<string>
    {

        [ForeignKey("GNEWSPAPERID")]
        public virtual Anu.BaseInfo.DataModel.Types.GNewspaper? TheGNewspaper { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("GNEWSPAPERUNIT")]
    public partial class GNewspaperUnit : GNewspaperUnitBase
    {
    }
}