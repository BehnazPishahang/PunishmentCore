

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Letter
{
    public abstract class PUnitTemplateBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[Column("TEMPLATETEXT")]
		public virtual string? TemplateText { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PUNITTEMPLATE")]
    public partial class PUnitTemplate : PUnitTemplateBase { }

    }


