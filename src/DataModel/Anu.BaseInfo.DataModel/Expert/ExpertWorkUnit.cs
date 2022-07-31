

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.Expert
{
    public abstract class ExpertWorkUnitBase : BaseInfoEntity<string>
    {

        [ForeignKey("EXPERTMANID")]
        public virtual Anu.BaseInfo.DataModel.Expert.ExpertMan? TheExpertMan { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("EXPERTWORKUNIT")]
    public partial class ExpertWorkUnit : ExpertWorkUnitBase
    {
    }
    }