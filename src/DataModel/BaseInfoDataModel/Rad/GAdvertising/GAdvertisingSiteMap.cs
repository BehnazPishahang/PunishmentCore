

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.GAdvertising
{
    public abstract class GAdvertisingSiteMapBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("GADVERTISINGID")]
		public virtual Rad.GAdvertising.GAdvertising? TheGAdvertising { get; set; }

    }
    [Table("GADVERTISINGSITEMAP")]
    public partial class GAdvertisingSiteMap : GAdvertisingSiteMapBase { }

    }


