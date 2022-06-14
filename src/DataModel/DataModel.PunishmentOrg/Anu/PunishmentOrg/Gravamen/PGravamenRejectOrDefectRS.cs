

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Gravamen
{
    public abstract class PGravamenRejectOrDefectRSBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBGRAVAMENREJECTDEFECTTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBGravamenRejectDefectType? ThePBGravamenRejectDefectType { get; set; }

		[ForeignKey("PGRAVAMENID")]
		public virtual Anu.PunishmentOrg.Gravamen.PGravamen? ThePGravamen { get; set; }

    }
    [Table("PGRAVAMENREJECTORDEFECTRS")]
    public partial class PGravamenRejectOrDefectRS : PGravamenRejectOrDefectRSBase { }

    }


