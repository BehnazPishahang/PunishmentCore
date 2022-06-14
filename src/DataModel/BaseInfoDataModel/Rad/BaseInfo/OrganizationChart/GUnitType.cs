

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.OrganizationChart
{
    public abstract class GUnitTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("RELATEDSUBSYSTEM")]
		public virtual Rad.CMS.Enumerations.Subsystems? RelatedSubsystem { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGUnitType")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GUNITTYPE")]
    public partial class GUnitType : GUnitTypeBase { }

    }


