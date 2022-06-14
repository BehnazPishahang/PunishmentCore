

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizLetTypeOutOrgBase : BaseInfoEntity<string>
    {

		[ForeignKey("GBNWMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLetterType? TheGBNWMechanizedLetterType { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

    }
    [Table("GBNWMECHANIZLETTYPEOUTORG")]
    public partial class GBNWMechanizLetTypeOutOrg : GBNWMechanizLetTypeOutOrgBase { }

    }


