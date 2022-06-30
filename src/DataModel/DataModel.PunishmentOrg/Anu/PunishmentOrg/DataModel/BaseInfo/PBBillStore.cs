

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
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
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

    }

    [Table("PBBILLSTORE")]
    public partial class PBBillStore : PBBillStoreBase
    {
    }
}