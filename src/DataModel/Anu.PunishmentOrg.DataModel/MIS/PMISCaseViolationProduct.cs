using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.PunishmentOrg.DataModel.MIS
{
    public abstract class PMISCaseViolationProductBase : PunishmentOrgEntity<string>
    {

        [Column("CONTRABANDPRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

        [Column("PRODUCTCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

        [Column("PRODUCTVALUE")]
        public virtual long? ProductValue { get; set; }

        [Column("SALEPRICE")]
        public virtual long? SalePrice { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [Column("STANDARDPRICE")]
        public virtual long? StandardPrice { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBPRODUCTCURRENCYTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

        [ForeignKey("PCASEPRODUCTID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCaseProduct? ThePCaseProduct { get; set; }

        [ForeignKey("PMISCASEVIOLATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.MIS.PMISCaseViolation? ThePMISCaseViolation { get; set; }

        }

    [Table("PMISCASEVIOLATIONPRODUCT")]
    public partial class PMISCaseViolationProduct : PMISCaseViolationProductBase
    {
    }
    }