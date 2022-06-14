

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizedLtrTpTemplateBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("LETTERTEXTDB")]
		public virtual string? LetterTextDB { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GBNWMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLetterType? TheGBNWMechanizedLetterType { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Rad.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GBNWMECHANIZEDLTRTPTEMPLATE")]
    public partial class GBNWMechanizedLtrTpTemplate : GBNWMechanizedLtrTpTemplateBase { }

    }


