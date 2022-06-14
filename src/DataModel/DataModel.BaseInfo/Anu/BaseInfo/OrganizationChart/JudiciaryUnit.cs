

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.OrganizationChart
{
    public abstract class JudiciaryUnitBase : BaseInfoEntity<string>
    {

		[Column("ADDRESS")]
		public virtual string? Address { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COURTTYPE")]
		public virtual Anu.Enumerations.CourtType? CourtType { get; set; }

		[Column("ISMECHANIZEREL")]
		public virtual Anu.Enumerations.YesNo? IsMechanizeRel { get; set; }

		[Column("LEVELCODE")]
		public virtual string? LevelCode { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentUnit")]
		public virtual List<Anu.BaseInfo.OrganizationChart.JudiciaryUnit>? TheChildUnitsList { get; set; }

		[ForeignKey("PARENTUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.JudiciaryUnit? TheParentUnit { get; set; }

		[Column("UNITNAME")]
		public virtual string? UnitName { get; set; }

		[Column("UNITTYPE")]
		public virtual Anu.Enumerations.JudiciaryUnitType? UnitType { get; set; }

    }
    [Table("JUDICIARYUNIT")]
    public partial class JudiciaryUnit : JudiciaryUnitBase { }

    }


