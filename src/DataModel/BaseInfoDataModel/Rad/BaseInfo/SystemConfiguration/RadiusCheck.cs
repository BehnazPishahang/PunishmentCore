

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class RadiusCheckBase : BaseInfoEntity<string>
    {

		[Column("DBRADIUSCHECKID")]
		public virtual decimal? DBRadiusCheckId { get; set; }

		[Column("PASSWORD")]
		public virtual string? Password { get; set; }

		[InverseProperty("TheRadiusCheck")]
		public virtual List<Rad.BaseInfo.SystemConfiguration.RadiusCheckChanges>? TheRadiusCheckChangesList { get; set; }

		[ForeignKey("SCRIPTORIUMID")]
		public virtual Rad.BaseInfo.OrganizationChart.Scriptorium? TheScriptorium { get; set; }

		[Column("USERNAME")]
		public virtual string? UserName { get; set; }

    }
    [Table("RADIUSCHECK")]
    public partial class RadiusCheck : RadiusCheckBase { }

    }


