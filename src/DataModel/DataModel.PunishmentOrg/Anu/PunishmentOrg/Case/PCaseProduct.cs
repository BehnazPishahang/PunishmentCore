

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Case
{
    public abstract class PCaseProductBase : PunishmentOrgEntity<string>
    {

		[Column("BILLSTOREPRODUCTVALUE")]
		public virtual decimal? BillStoreProductValue { get; set; }

		[Column("BRANDNAME")]
		public virtual string? BrandName { get; set; }

		[Column("CONTRABANDPRODUCTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.ContrabandProductType? ContrabandProductType { get; set; }

		[Column("COUNTRYCREATE")]
		public virtual string? CountryCreate { get; set; }

		[Column("CURRENCYUNIT")]
		public virtual string? CurrencyUnit { get; set; }

		[Column("CURRENCYVALUE")]
		public virtual long? CurrencyValue { get; set; }

		[Column("ESTIMATEDVALUE")]
		public virtual decimal? EstimatedValue { get; set; }

		[Column("OTHERINFO")]
		public virtual string? OtherInfo { get; set; }

		[Column("PRODUCTCURRENCY")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUProductCurrency? ProductCurrency { get; set; }

		[Column("PRODUCTID")]
		public virtual string? ProductID { get; set; }

		[Column("PRODUCTTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PProductType? ProductType { get; set; }

		[Column("PRODUCTVALUE")]
		public virtual decimal? ProductValue { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[Column("SALEPRICE")]
		public virtual long? SalePrice { get; set; }

		[Column("SERIALNUMBER")]
		public virtual string? SerialNumber { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("SOURCEPRODUCTVALUE")]
		public virtual decimal? SourceProductValue { get; set; }

		[Column("SOURCEROWNUMBER")]
		public virtual long? SourceRowNumber { get; set; }

		[Column("STANDARDPRICE")]
		public virtual long? StandardPrice { get; set; }

		[Column("SUBJECTTITLE")]
		public virtual string? SubjectTitle { get; set; }

		[ForeignKey("GEXCHANGEUNITTITLEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.ExchangeData.GExchangeUnitTitle? TheGExchangeUnitTitle { get; set; }

		[ForeignKey("MEASUREMENTUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.MeasurementUnitType? TheMeasurementUnitType { get; set; }

		[ForeignKey("PBPRODUCTCURRENCYTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductCurrencyType? ThePBProductCurrencyType { get; set; }

		[ForeignKey("PBPRODUCTIDTYPEID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBProductIDType? ThePBProductIDType { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[InverseProperty("ThePCaseProduct")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseBindingSubjectProduct>? ThePCaseBindingSubjectProductList { get; set; }

		[InverseProperty("ThePCaseProduct")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseProductPerson>? ThePCaseProductPersonList { get; set; }

		[InverseProperty("ThePCaseProduct")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseProductViolation>? ThePCaseProductViolationList { get; set; }

		[InverseProperty("ThePCaseProduct")]
		public virtual List<Anu.PunishmentOrg.Case.PCaseViolationProductBillST>? ThePCaseViolationProductBillSTList { get; set; }

    }
    [Table("PCASEPRODUCT")]
    public partial class PCaseProduct : PCaseProductBase { }

    }


