

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.BaseInfo.DataModel.OrganizationChart
{
    public abstract class GUnitImagesBase : BaseInfoEntity<string>
    {

        [Column("DOCFILE")]
        public virtual byte[]? DocFile { get; set; }

        [ForeignKey("GUNITIMAGETYPEID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.GUnitImageType? TheGUnitImageType { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

    }

    [Table("GUNITIMAGES")]
    public partial class GUnitImages : GUnitImagesBase
    {
    }
    }