

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BaseInfo
{
    public abstract class PBProductCurrencyTypeBase : PunishmentOrgEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("ISPROHIBITEDGOODS")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsProhibitedGoods { get; set; }

        [Column("LEVELCODE")]
        public virtual string? LevelCode { get; set; }

        [Column("NATIONALCODE")]
        public virtual string? NationalCode { get; set; }

        [Column("PRODUCTCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheParentProductCurrency")]
        public virtual List<Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType>? TheChildProductCurrencyList { get; set; }

        [ForeignKey("GMEASUREMENTBASICUNITID")]
        public virtual Anu.BaseInfo.DataModel.Types.GMeasurementBasicUnit? TheGMeasurementBasicUnit { get; set; }

        [ForeignKey("PARENTPRODUCTCURRENCYID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? TheParentProductCurrency { get; set; }

        [Column("TITLE")]
        public virtual string? Title { get; set; }

    }

    [Table("PBPRODUCTCURRENCYTYPE")]
    public partial class PBProductCurrencyType : PBProductCurrencyTypeBase
    {
    }
}