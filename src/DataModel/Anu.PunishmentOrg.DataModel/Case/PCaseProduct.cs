

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataModel.Case
{
    public abstract class PCaseProductBase : PunishmentOrgEntity<string>
    {

        [Column("BILLSTOREPRODUCTVALUE")]
        public virtual decimal? BillStoreProductValue { get; set; }

        [Unicode(false)]
        [Column("BRANDNAME")]
        public virtual string? BrandName { get; set; }

        [Column("CONTRABANDPRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.ContrabandProductType? ContrabandProductType { get; set; }

        [Unicode(false)]
        [Column("COUNTRYCREATE")]
        public virtual string? CountryCreate { get; set; }

        [Unicode(false)]
        [Column("CURRENCYUNIT")]
        public virtual string? CurrencyUnit { get; set; }

        [Column("CURRENCYVALUE")]
        public virtual long? CurrencyValue { get; set; }

        [Column("ESTIMATEDVALUE")]
        public virtual decimal? EstimatedValue { get; set; }

        [Unicode(false)]
        [Column("GENERALPRODUCTID")]
        public virtual string? GeneralProductID { get; set; }

        [Unicode(false)]
        [Column("OTHERINFO")]
        public virtual string? OtherInfo { get; set; }

        [Column("PRODUCTCURRENCY")]
        public virtual Anu.PunishmentOrg.Enumerations.PUProductCurrency? ProductCurrency { get; set; }

        [Unicode(false)]
        [Column("PRODUCTID")]
        public virtual string? ProductID { get; set; }

        [Column("PRODUCTTYPE")]
        public virtual Anu.PunishmentOrg.Enumerations.PProductType? ProductType { get; set; }

        [Column("PRODUCTVALUE")]
        public virtual decimal? ProductValue { get; set; }

        [Column("ROWNUMBER")]
        public virtual long? RowNumber { get; set; }

        [Column("SALEPRICE")]
        public virtual long? SalePrice { get; set; }

        [Unicode(false)]
        [Column("SERIALNUMBER")]
        public virtual string? SerialNumber { get; set; }

        [Unicode(false)]
        [Column("SOURCEOBJECTID")]
        public virtual string? SourceObjectId { get; set; }

        [Column("SOURCEPRODUCTVALUE")]
        public virtual decimal? SourceProductValue { get; set; }

        [Column("SOURCEROWNUMBER")]
        public virtual long? SourceRowNumber { get; set; }

        [Column("STANDARDPRICE")]
        public virtual long? StandardPrice { get; set; }

        [Unicode(false)]
        [Column("SUBJECTTITLE")]
        public virtual string? SubjectTitle { get; set; }

        [ForeignKey("GEXCHANGEUNITTITLEID")]
        public virtual Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

        [ForeignKey("MEASUREMENTUNITTYPEID")]
        public virtual Anu.BaseInfo.DataModel.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

        [ForeignKey("PBPRODUCTCURRENCYTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

        [ForeignKey("PBPRODUCTIDTYPEID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBProductIDType? ThePBProductIDType { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [InverseProperty("ThePCaseProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseBindingSubjectProduct>? ThePCaseBindingSubjectProductList { get; set; }

        [InverseProperty("ThePCaseProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseProductPerson>? ThePCaseProductPersonList { get; set; }

        [InverseProperty("ThePCaseProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseProductViolation>? ThePCaseProductViolationList { get; set; }

        [InverseProperty("ThePCaseProduct")]
        public virtual List<Anu.PunishmentOrg.DataModel.Case.PCaseViolationProductBillST>? ThePCaseViolationProductBillSTList { get; set; }

    }

    [Table("PCASEPRODUCT")]
    public partial class PCaseProduct : PCaseProductBase
    {
    }
    }