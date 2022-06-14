

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.SystemConfiguration
{
    public abstract class RadiusCheckChangesBase : BaseInfoEntity<string>
    {

		[Column("ADMINNAMEFAMILY")]
		public virtual string? AdminNameFamily { get; set; }

		[Column("EVENTDATETIME")]
		public virtual string? EventDateTime { get; set; }

		[ForeignKey("RADIUSCHECKID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RadiusCheck? TheRadiusCheck { get; set; }

    }
    [Table("RADIUSCHECKCHANGES")]
    public partial class RadiusCheckChanges : RadiusCheckChangesBase { }

    }


