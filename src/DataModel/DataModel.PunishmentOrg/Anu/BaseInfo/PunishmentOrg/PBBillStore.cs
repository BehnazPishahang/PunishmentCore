

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBBillStoreBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("ORGID")]
		public virtual long? OrgID { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

    }
    [Table("PBBILLSTORE")]
    public partial class PBBillStore : PBBillStoreBase { }

    }


