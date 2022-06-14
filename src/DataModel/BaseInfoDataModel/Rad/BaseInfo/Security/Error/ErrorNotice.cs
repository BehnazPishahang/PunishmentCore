

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Security.Error
{
    public abstract class ErrorNoticeBase : BaseInfoEntity<string>
    {

		[Column("CORRECTOR")]
		public virtual string? Corrector { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("ERRORDATETIME")]
		public virtual string? ErrorDateTime { get; set; }

		[Column("ERRORDESCRIPTION")]
		public virtual string? ErrorDescription { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("REPAIRDATETIME")]
		public virtual string? RepairDateTime { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

    }
    [Table("ERRORNOTICE")]
    public partial class ErrorNotice : ErrorNoticeBase { }

    }


