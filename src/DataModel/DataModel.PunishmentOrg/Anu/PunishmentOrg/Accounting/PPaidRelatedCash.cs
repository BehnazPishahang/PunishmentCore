

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PPaidRelatedCashBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PCASHID")]
		public virtual Anu.PunishmentOrg.Accounting.PCash? ThePCash { get; set; }

		[ForeignKey("PPAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PPaid? ThePPaid { get; set; }

    }
    [Table("PPAIDRELATEDCASH")]
    public partial class PPaidRelatedCash : PPaidRelatedCashBase { }

    }


