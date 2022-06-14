

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizLetTypeInOrgBase : BaseInfoEntity<string>
    {

		[Column("SENDERRECEIVER")]
		public virtual Rad.CMS.Enumerations.MechanizLetTypeSenderReceiver? SenderReceiver { get; set; }

		[ForeignKey("GBNWMECHANIZEDLETTERTYPEID")]
		public virtual Rad.BaseInfo.NewExchangeData.GBNWMechanizedLetterType? TheGBNWMechanizedLetterType { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual Rad.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

    }
    [Table("GBNWMECHANIZLETTYPEINORG")]
    public partial class GBNWMechanizLetTypeInOrg : GBNWMechanizLetTypeInOrgBase { }

    }


