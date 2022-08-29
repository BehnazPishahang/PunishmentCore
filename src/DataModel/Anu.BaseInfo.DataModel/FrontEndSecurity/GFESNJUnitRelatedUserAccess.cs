using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.FrontEndSecurity
{
    public abstract class GFESNJUnitRelatedUserAccessBase : BaseInfoEntity<string>
    {

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [ForeignKey("GFESUSERACCESSTYPEID")]
        public virtual Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

        }

    [Table("GFESNJUNITRELATEDUSERACCESS")]
    public partial class GFESNJUnitRelatedUserAccess : GFESNJUnitRelatedUserAccessBase
    {
    }
    }