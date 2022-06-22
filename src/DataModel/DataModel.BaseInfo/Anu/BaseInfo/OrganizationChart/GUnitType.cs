

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart
{
    public abstract class GUnitTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheGUnitType")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.GRoleTypeValidInUnitType>? TheGRoleTypeValidInUnitTypeList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("GUNITTYPE")]
    public partial class GUnitType : GUnitTypeBase { }

    }


