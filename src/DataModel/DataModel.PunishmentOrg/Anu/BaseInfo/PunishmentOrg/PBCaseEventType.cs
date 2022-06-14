

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBCaseEventTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBCASEEVENTTYPE")]
    public partial class PBCaseEventType : PBCaseEventTypeBase { }

    }


