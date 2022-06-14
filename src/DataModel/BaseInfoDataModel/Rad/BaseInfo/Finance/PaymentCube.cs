

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Finance
{
    public abstract class PaymentCubeBase : BaseInfoEntity<string>
    {

		[Column("CARDNO")]
		public virtual string? CardNo { get; set; }

		[Column("CMSORGANIZATIONID")]
		public virtual string? CMSOrganizationId { get; set; }

		[Column("CMSUSERID")]
		public virtual string? CMSUserId { get; set; }

		[Column("COSTTYPEID1")]
		public virtual string? CostTypeId1 { get; set; }

		[Column("COSTTYPEID10")]
		public virtual string? CostTypeId10 { get; set; }

		[Column("COSTTYPEID11")]
		public virtual string? CostTypeId11 { get; set; }

		[Column("COSTTYPEID12")]
		public virtual string? CostTypeId12 { get; set; }

		[Column("COSTTYPEID13")]
		public virtual string? CostTypeId13 { get; set; }

		[Column("COSTTYPEID14")]
		public virtual string? CostTypeId14 { get; set; }

		[Column("COSTTYPEID15")]
		public virtual string? CostTypeId15 { get; set; }

		[Column("COSTTYPEID16")]
		public virtual string? CostTypeId16 { get; set; }

		[Column("COSTTYPEID17")]
		public virtual string? CostTypeId17 { get; set; }

		[Column("COSTTYPEID18")]
		public virtual string? CostTypeId18 { get; set; }

		[Column("COSTTYPEID19")]
		public virtual string? CostTypeId19 { get; set; }

		[Column("COSTTYPEID2")]
		public virtual string? CostTypeId2 { get; set; }

		[Column("COSTTYPEID20")]
		public virtual string? CostTypeId20 { get; set; }

		[Column("COSTTYPEID3")]
		public virtual string? CostTypeId3 { get; set; }

		[Column("COSTTYPEID4")]
		public virtual string? CostTypeId4 { get; set; }

		[Column("COSTTYPEID5")]
		public virtual string? CostTypeId5 { get; set; }

		[Column("COSTTYPEID6")]
		public virtual string? CostTypeId6 { get; set; }

		[Column("COSTTYPEID7")]
		public virtual string? CostTypeId7 { get; set; }

		[Column("COSTTYPEID8")]
		public virtual string? CostTypeId8 { get; set; }

		[Column("COSTTYPEID9")]
		public virtual string? CostTypeId9 { get; set; }

		[Column("COSTTYPEPRICE1")]
		public virtual decimal? CostTypePrice1 { get; set; }

		[Column("COSTTYPEPRICE10")]
		public virtual decimal? CostTypePrice10 { get; set; }

		[Column("COSTTYPEPRICE11")]
		public virtual decimal? CostTypePrice11 { get; set; }

		[Column("COSTTYPEPRICE12")]
		public virtual decimal? CostTypePrice12 { get; set; }

		[Column("COSTTYPEPRICE13")]
		public virtual decimal? CostTypePrice13 { get; set; }

		[Column("COSTTYPEPRICE14")]
		public virtual decimal? CostTypePrice14 { get; set; }

		[Column("COSTTYPEPRICE15")]
		public virtual decimal? CostTypePrice15 { get; set; }

		[Column("COSTTYPEPRICE16")]
		public virtual decimal? CostTypePrice16 { get; set; }

		[Column("COSTTYPEPRICE17")]
		public virtual decimal? CostTypePrice17 { get; set; }

		[Column("COSTTYPEPRICE18")]
		public virtual decimal? CostTypePrice18 { get; set; }

		[Column("COSTTYPEPRICE19")]
		public virtual decimal? CostTypePrice19 { get; set; }

		[Column("COSTTYPEPRICE2")]
		public virtual decimal? CostTypePrice2 { get; set; }

		[Column("COSTTYPEPRICE20")]
		public virtual decimal? CostTypePrice20 { get; set; }

		[Column("COSTTYPEPRICE3")]
		public virtual decimal? CostTypePrice3 { get; set; }

		[Column("COSTTYPEPRICE4")]
		public virtual decimal? CostTypePrice4 { get; set; }

		[Column("COSTTYPEPRICE5")]
		public virtual decimal? CostTypePrice5 { get; set; }

		[Column("COSTTYPEPRICE6")]
		public virtual decimal? CostTypePrice6 { get; set; }

		[Column("COSTTYPEPRICE7")]
		public virtual decimal? CostTypePrice7 { get; set; }

		[Column("COSTTYPEPRICE8")]
		public virtual decimal? CostTypePrice8 { get; set; }

		[Column("COSTTYPEPRICE9")]
		public virtual decimal? CostTypePrice9 { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("DOCUMENTDATE")]
		public virtual string? DocumentDate { get; set; }

		[Column("EPAYMENTID")]
		public virtual string? EPaymentId { get; set; }

		[Column("GEOLOCATIONID")]
		public virtual string? GeoLocationId { get; set; }

		[Column("HOWTOQUOTATION")]
		public virtual string? HowToQuotation { get; set; }

		[Column("MERCHANTREPORTID")]
		public virtual string? MerchantReportId { get; set; }

		[Column("NATIONALNO")]
		public virtual string? NationalNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("OSTANID")]
		public virtual string? OstanId { get; set; }

		[Column("PAYMENTDATETIME")]
		public virtual string? PaymentDateTime { get; set; }

		[Column("PAYMENTNO")]
		public virtual string? PaymentNo { get; set; }

		[Column("PAYMENTOTHERINFORMATION")]
		public virtual string? PaymentOtherInformation { get; set; }

		[Column("PAYMENTTYPE")]
		public virtual string? PaymentType { get; set; }

		[Column("PRICE")]
		public virtual decimal? Price { get; set; }

		[Column("PSPADDDATA")]
		public virtual string? PSPAddData { get; set; }

		[Column("PSPCARDNO")]
		public virtual string? PSPCardNo { get; set; }

		[Column("PSPCYCLE")]
		public virtual string? PSPCycle { get; set; }

		[Column("PSPFACTORNO")]
		public virtual string? PSPFactorNo { get; set; }

		[Column("PSPMERCHANT")]
		public virtual string? PSPMerchant { get; set; }

		[Column("PSPPAYMENTCODE")]
		public virtual string? PSPPaymentCode { get; set; }

		[Column("PSPPRICE")]
		public virtual decimal? PSPPrice { get; set; }

		[Column("PSPRECIEPTCODE")]
		public virtual string? PSPRecieptCode { get; set; }

		[Column("PSPREPORTDATETIME")]
		public virtual string? PSPReportDateTime { get; set; }

		[Column("PSPRRN")]
		public virtual string? PSPRRN { get; set; }

		[Column("PSPSENTTOREVERSE")]
		public virtual string? PSPSentToReverse { get; set; }

		[Column("PSPSENTTOSETTLE")]
		public virtual string? PSPSentToSettle { get; set; }

		[Column("PSPSERVICE")]
		public virtual string? PSPService { get; set; }

		[Column("PSPSETTLEMENTDATETIME")]
		public virtual string? PSPSettlementDateTime { get; set; }

		[Column("PSPSETTLESUCCESSFUL")]
		public virtual string? PSPSettleSuccessful { get; set; }

		[Column("PSPSHEBA")]
		public virtual string? PSPSheba { get; set; }

		[Column("PSPSWITCHRESPONSE")]
		public virtual string? PSPSwitchResponse { get; set; }

		[Column("PSPTERMINAL")]
		public virtual string? PSPTerminal { get; set; }

		[Column("PSPTRANSACTIONBASE")]
		public virtual string? PSPTransactionBase { get; set; }

		[Column("PSPTRANSACTIONCODE")]
		public virtual string? PSPTransactionCode { get; set; }

		[Column("PSPTRANSACTIONDATETIME")]
		public virtual string? PSPTransactionDateTime { get; set; }

		[Column("PSPTRANSACTIONRETURNDATETIME")]
		public virtual string? PSPTransactionReturnDateTime { get; set; }

		[Column("PSPTRANSACTIONSERIALNO")]
		public virtual string? PSPTransactionSerialNo { get; set; }

		[Column("PSPTRANSUCCESSFUL")]
		public virtual string? PSPTranSuccessful { get; set; }

		[Column("QUANTITY")]
		public virtual decimal? Quantity { get; set; }

		[Column("SCRIPTORIUMID")]
		public virtual string? ScriptoriumId { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK10")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK10 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK11")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK11 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK12")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK12 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK13")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK13 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK14")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK14 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK15")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK15 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK16")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK16 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK17")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK17 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK18")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK18 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK19")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK19 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK2")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK2 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK20")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK20 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK3")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK3 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK4")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK4 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK5")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK5 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK6")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK6 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK7")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK7 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK8")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK8 { get; set; }

		[Column("SHAPARAK_AMOUNTSHAPARAK9")]
		public virtual decimal? SHAPARAK_AMOUNTSHAPARAK9 { get; set; }

		[Column("SHAPARAK_IBAN")]
		public virtual string? SHAPARAK_IBAN { get; set; }

		[Column("SHAPARAK_IBAN10")]
		public virtual string? SHAPARAK_IBAN10 { get; set; }

		[Column("SHAPARAK_IBAN11")]
		public virtual string? SHAPARAK_IBAN11 { get; set; }

		[Column("SHAPARAK_IBAN12")]
		public virtual string? SHAPARAK_IBAN12 { get; set; }

		[Column("SHAPARAK_IBAN13")]
		public virtual string? SHAPARAK_IBAN13 { get; set; }

		[Column("SHAPARAK_IBAN14")]
		public virtual string? SHAPARAK_IBAN14 { get; set; }

		[Column("SHAPARAK_IBAN15")]
		public virtual string? SHAPARAK_IBAN15 { get; set; }

		[Column("SHAPARAK_IBAN16")]
		public virtual string? SHAPARAK_IBAN16 { get; set; }

		[Column("SHAPARAK_IBAN17")]
		public virtual string? SHAPARAK_IBAN17 { get; set; }

		[Column("SHAPARAK_IBAN18")]
		public virtual string? SHAPARAK_IBAN18 { get; set; }

		[Column("SHAPARAK_IBAN19")]
		public virtual string? SHAPARAK_IBAN19 { get; set; }

		[Column("SHAPARAK_IBAN2")]
		public virtual string? SHAPARAK_IBAN2 { get; set; }

		[Column("SHAPARAK_IBAN20")]
		public virtual string? SHAPARAK_IBAN20 { get; set; }

		[Column("SHAPARAK_IBAN3")]
		public virtual string? SHAPARAK_IBAN3 { get; set; }

		[Column("SHAPARAK_IBAN4")]
		public virtual string? SHAPARAK_IBAN4 { get; set; }

		[Column("SHAPARAK_IBAN5")]
		public virtual string? SHAPARAK_IBAN5 { get; set; }

		[Column("SHAPARAK_IBAN6")]
		public virtual string? SHAPARAK_IBAN6 { get; set; }

		[Column("SHAPARAK_IBAN7")]
		public virtual string? SHAPARAK_IBAN7 { get; set; }

		[Column("SHAPARAK_IBAN8")]
		public virtual string? SHAPARAK_IBAN8 { get; set; }

		[Column("SHAPARAK_IBAN9")]
		public virtual string? SHAPARAK_IBAN9 { get; set; }

		[Column("SHAPARAK_LOCALDATE")]
		public virtual string? SHAPARAK_LOCALDATE { get; set; }

		[Column("SHAPARAK_LOCALTIME")]
		public virtual string? SHAPARAK_LOCALTIME { get; set; }

		[Column("SHAPARAK_MERCHANTID")]
		public virtual string? SHAPARAK_MERCHANTID { get; set; }

		[Column("SHAPARAK_PROCTYPE")]
		public virtual string? SHAPARAK_PROCTYPE { get; set; }

		[Column("SHAPARAK_PURNUMBER")]
		public virtual string? SHAPARAK_PURNUMBER { get; set; }

		[Column("SHAPARAK_RID")]
		public virtual string? SHAPARAK_RID { get; set; }

		[Column("SHAPARAK_RID10")]
		public virtual string? SHAPARAK_RID10 { get; set; }

		[Column("SHAPARAK_RID11")]
		public virtual string? SHAPARAK_RID11 { get; set; }

		[Column("SHAPARAK_RID12")]
		public virtual string? SHAPARAK_RID12 { get; set; }

		[Column("SHAPARAK_RID13")]
		public virtual string? SHAPARAK_RID13 { get; set; }

		[Column("SHAPARAK_RID14")]
		public virtual string? SHAPARAK_RID14 { get; set; }

		[Column("SHAPARAK_RID15")]
		public virtual string? SHAPARAK_RID15 { get; set; }

		[Column("SHAPARAK_RID16")]
		public virtual string? SHAPARAK_RID16 { get; set; }

		[Column("SHAPARAK_RID17")]
		public virtual string? SHAPARAK_RID17 { get; set; }

		[Column("SHAPARAK_RID18")]
		public virtual string? SHAPARAK_RID18 { get; set; }

		[Column("SHAPARAK_RID19")]
		public virtual string? SHAPARAK_RID19 { get; set; }

		[Column("SHAPARAK_RID2")]
		public virtual string? SHAPARAK_RID2 { get; set; }

		[Column("SHAPARAK_RID20")]
		public virtual string? SHAPARAK_RID20 { get; set; }

		[Column("SHAPARAK_RID3")]
		public virtual string? SHAPARAK_RID3 { get; set; }

		[Column("SHAPARAK_RID4")]
		public virtual string? SHAPARAK_RID4 { get; set; }

		[Column("SHAPARAK_RID5")]
		public virtual string? SHAPARAK_RID5 { get; set; }

		[Column("SHAPARAK_RID6")]
		public virtual string? SHAPARAK_RID6 { get; set; }

		[Column("SHAPARAK_RID7")]
		public virtual string? SHAPARAK_RID7 { get; set; }

		[Column("SHAPARAK_RID8")]
		public virtual string? SHAPARAK_RID8 { get; set; }

		[Column("SHAPARAK_RID9")]
		public virtual string? SHAPARAK_RID9 { get; set; }

		[Column("SHAPARAK_SETTLECYCLECODE")]
		public virtual string? SHAPARAK_SETTLECYCLECODE { get; set; }

		[Column("SHAPARAK_SETTLEDATE")]
		public virtual string? SHAPARAK_SETTLEDATE { get; set; }

		[Column("SHAPARAK_STAN")]
		public virtual string? SHAPARAK_STAN { get; set; }

		[Column("SHAPARAK_TERMINALID")]
		public virtual string? SHAPARAK_TERMINALID { get; set; }

		[Column("SHAPARAK_TERMINALTYPE")]
		public virtual string? SHAPARAK_TERMINALTYPE { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.EPaymentState? State { get; set; }

		[Column("SYSTEMFORMID")]
		public virtual string? SystemFormId { get; set; }

		[Column("SYSTEMNAME")]
		public virtual string? SystemName { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITID")]
		public virtual string? UnitId { get; set; }

    }
    [Table("PAYMENTCUBE")]
    public partial class PaymentCube : PaymentCubeBase { }

    }


