

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Accounting
{
    public abstract class PBill4PaidCaseBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PBILL4PAIDID")]
		public virtual Anu.PunishmentOrg.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

    }
    [Table("PBILL4PAIDCASE")]
    public partial class PBill4PaidCase : PBill4PaidCaseBase { }

    }


