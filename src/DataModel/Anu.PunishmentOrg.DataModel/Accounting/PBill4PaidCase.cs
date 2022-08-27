using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.Accounting
{
    public abstract class PBill4PaidCaseBase : PunishmentOrgEntity<string>
    {

        [ForeignKey("PBILL4PAIDID")]
        public virtual Anu.PunishmentOrg.DataModel.Accounting.PBill4Paid? ThePBill4Paid { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        }

    [Table("PBILL4PAIDCASE")]
    public partial class PBill4PaidCase : PBill4PaidCaseBase
    {
    }
    }