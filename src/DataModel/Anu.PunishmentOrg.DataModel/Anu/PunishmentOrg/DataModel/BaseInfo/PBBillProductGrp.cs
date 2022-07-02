

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
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