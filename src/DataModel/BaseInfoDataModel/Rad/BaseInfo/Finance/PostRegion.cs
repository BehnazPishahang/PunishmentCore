

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class PostRegionBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[Column("BEHDADNO")]
		public virtual string? BehdadNo { get; set; }

		[Column("SHEBANO")]
		public virtual string? ShebaNo { get; set; }

		[ForeignKey("POSTREGIONGEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? ThePostRegionGeoLocation { get; set; }

		[InverseProperty("ThePostRegion")]
		public virtual List<Rad.BaseInfo.Finance.PostRegionOrganization>? ThePostRegionOrganizationList { get; set; }

		[ForeignKey("POSTREGIONOSTANID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? ThePostRegionOstan { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("POSTREGION")]
    public partial class PostRegion : PostRegionBase { }

    }


