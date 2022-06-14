

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESNJUnitRelatedUserAccessBase : BaseInfoEntity<string>
    {

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

    }
    [Table("GFESNJUNITRELATEDUSERACCESS")]
    public partial class GFESNJUnitRelatedUserAccess : GFESNJUnitRelatedUserAccessBase { }

    }


