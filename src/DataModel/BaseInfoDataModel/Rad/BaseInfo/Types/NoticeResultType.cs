

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class NoticeResultTypeBase : BaseInfoEntity<string>
    {

		[Column("ARTICLE")]
		public virtual string? Article { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("PERSONKIND")]
		public virtual Rad.CMS.Enumerations.KindsOfNoticePeople? PersonKind { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("RESULTTYPE")]
		public virtual Rad.CMS.Enumerations.NoticeResultType? ResultType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("NOTICERESULTTYPE")]
    public partial class NoticeResultType : NoticeResultTypeBase { }

    }


