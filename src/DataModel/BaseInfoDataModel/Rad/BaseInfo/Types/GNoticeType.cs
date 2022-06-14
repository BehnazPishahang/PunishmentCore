

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GNoticeTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGNoticeType")]
		public virtual List<Rad.BaseInfo.Types.GNoticeTypeTranscript>? TheGNoticeTypeTranscriptList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("TITLEINPRINT")]
		public virtual string? TitleInPrint { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("GNOTICETYPE")]
    public partial class GNoticeType : GNoticeTypeBase { }

    }


