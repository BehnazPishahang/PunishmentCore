

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeDefectBase : PunishmentOrgEntity<string>
    {

		[Column("DEFECTTITLE")]
		public virtual string? DefectTitle { get; set; }

		[ForeignKey("PBDEFECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBDefectType? ThePBDefectType { get; set; }

		[ForeignKey("PNOTICEID")]
		public virtual Anu.PunishmentOrg.Notice.PNotice? ThePNotice { get; set; }

    }
    [Table("PNOTICEDEFECT")]
    public partial class PNoticeDefect : PNoticeDefectBase { }

    }


