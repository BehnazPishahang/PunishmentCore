

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GeoInfo
{
    public abstract class SabteAhvalUnitNameBase : BaseInfoEntity<string>
    {

		[Column("FROMCODE")]
		public virtual string? FromCode { get; set; }

		[Column("SAHVALUNITNAME")]
		public virtual string? SAhvalUnitName { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[Column("TOCODE")]
		public virtual string? ToCode { get; set; }

    }
    [Table("SABTEAHVALUNITNAME")]
    public partial class SabteAhvalUnitName : SabteAhvalUnitNameBase { }

    }


