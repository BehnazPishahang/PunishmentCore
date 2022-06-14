

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Accounting
{
    public abstract class PTreasuryRandomNumBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ISPAID")]
		public virtual Anu.Enumerations.YesNo? IsPaid { get; set; }

		[Column("POSNUMBER")]
		public virtual string? POSNumber { get; set; }

		[Column("TREASURYNUMBER")]
		public virtual string? TreasuryNumber { get; set; }

    }
    [Table("PTREASURYRANDOMNUM")]
    public partial class PTreasuryRandomNum : PTreasuryRandomNumBase { }

    }


