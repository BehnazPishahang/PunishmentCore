

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class ForestCoAccountsBase : BaseInfoEntity<string>
    {

		[Column("ACCOUNTNO")]
		public virtual string? AccountNo { get; set; }

		[Column("BEHDADNO")]
		public virtual string? BehdadNo { get; set; }

		[Column("SHEBANO")]
		public virtual string? ShebaNo { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual Rad.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

    }
    [Table("FORESTCOACCOUNTS")]
    public partial class ForestCoAccounts : ForestCoAccountsBase { }

    }


