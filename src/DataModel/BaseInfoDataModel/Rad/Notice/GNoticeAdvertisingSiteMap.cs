

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Notice
{
    public abstract class GNoticeAdvertisingSiteMapBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[ForeignKey("GNOTICEADVERTISINGID")]
		public virtual Rad.Notice.GNoticeAdvertising? TheGNoticeAdvertising { get; set; }

    }
    [Table("GNOTICEADVERTISINGSITEMAP")]
    public partial class GNoticeAdvertisingSiteMap : GNoticeAdvertisingSiteMapBase { }

    }


