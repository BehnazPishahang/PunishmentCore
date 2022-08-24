using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GUnitRelatedNajaUnitBase : BaseInfoEntity<string>
    {

        [ForeignKey("NAJAUNITID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

        [ForeignKey("UNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheUnit { get; set; }

        }

    [Table("GUNITRELATEDNAJAUNIT")]
    public partial class GUnitRelatedNajaUnit : GUnitRelatedNajaUnitBase
    {
    }
    }