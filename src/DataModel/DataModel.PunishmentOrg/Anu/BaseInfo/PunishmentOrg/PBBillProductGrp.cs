

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBBillProductGrpBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NAME")]
		public virtual string? Name { get; set; }

		[Column("ORGCODE")]
		public virtual string? OrgCode { get; set; }

		[Column("ORGID")]
		public virtual long? OrgID { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheParentBillProductGrp")]
		public virtual List<Anu.BaseInfo.PunishmentOrg.PBBillProductGrp>? TheChildBillProductGrpList { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("PARENTBILLPRODUCTGRPID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBBillProductGrp? TheParentBillProductGrp { get; set; }

    }
    [Table("PBBILLPRODUCTGRP")]
    public partial class PBBillProductGrp : PBBillProductGrpBase { }

    }


