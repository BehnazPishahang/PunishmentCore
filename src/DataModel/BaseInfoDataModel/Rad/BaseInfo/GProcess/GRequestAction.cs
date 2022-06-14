

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.GProcess
{
    public abstract class GRequestActionBase : BaseInfoEntity<string>
    {

		[Column("ACTIONDATE")]
		public virtual string? ActionDate { get; set; }

		[Column("ACTIONNO")]
		public virtual string? ActionNo { get; set; }

		[Column("ACTIONTEXT")]
		public virtual string? ActionText { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[ForeignKey("GPROCESSSTEPID")]
		public virtual Rad.BaseInfo.GProcess.GProcessStep? TheGProcessStep { get; set; }

		[ForeignKey("GREQUESTID")]
		public virtual Rad.BaseInfo.GProcess.GRequest? TheGRequest { get; set; }

		[ForeignKey("GREQUESTREFERID")]
		public virtual Rad.BaseInfo.GProcess.GRequestRefer? TheGRequestRefer { get; set; }

    }
    [Table("GREQUESTACTION")]
    public partial class GRequestAction : GRequestActionBase { }

    }


