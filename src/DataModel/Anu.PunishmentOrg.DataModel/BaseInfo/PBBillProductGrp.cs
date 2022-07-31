

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBBillProductGrpBase : PunishmentOrgEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Unicode(false)]
        [Column("NAME")]
        public virtual string? Name { get; set; }

        [Unicode(false)]
        [Column("ORGCODE")]
        public virtual string? OrgCode { get; set; }

        [Column("ORGID")]
        public virtual long? OrgID { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheParentBillProductGrp")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBBillProductGrp>? TheChildBillProductGrpList { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [ForeignKey("PARENTBILLPRODUCTGRPID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillProductGrp? TheParentBillProductGrp { get; set; }

    }

    [Table("PBBILLPRODUCTGRP")]
    public partial class PBBillProductGrp : PBBillProductGrpBase
    {
    }
    }