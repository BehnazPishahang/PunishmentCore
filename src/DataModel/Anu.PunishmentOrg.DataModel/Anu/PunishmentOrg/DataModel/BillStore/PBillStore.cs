

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.DataModel.BillStore
{
    public abstract class PBillStoreBase : PunishmentOrgEntity<string>
    {

        [Column("AGG_NUMBER")]
        public virtual string? agg_number { get; set; }

        [Column("BILLDATE")]
        public virtual string? BillDate { get; set; }

        [Column("BILLNO")]
        public virtual string? BillNo { get; set; }

        [Column("COURTORDERDATE")]
        public virtual string? CourtOrderDate { get; set; }

        [Column("COURTORDERNO")]
        public virtual string? CourtOrderNo { get; set; }

        [Column("CREATEDATETIME")]
        public virtual string? CreateDateTime { get; set; }

        [Column("DELIVERDATE")]
        public virtual string? DeliverDate { get; set; }

        [Column("DELIVERTIME")]
        public virtual string? DeliverTime { get; set; }

        [Column("DELIVERYFAMILY")]
        public virtual string? DeliveryFamily { get; set; }

        [Column("DELIVERYNAME")]
        public virtual string? DeliveryName { get; set; }

        [Column("DELIVERYNATIONALCODE")]
        public virtual string? DeliveryNationalCode { get; set; }

        [Column("ID_SHENASEANBAR")]
        public virtual string? id_shenaseAnbar { get; set; }

        [Column("ID_SHENASERESID")]
        public virtual string? id_shenaseResid { get; set; }

        [Column("ISEQUALITY")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsEquality { get; set; }

        [Column("ISISSUEAFTERDISMIN")]
        public virtual Anu.BaseInfo.Enumerations.YesNo? IsIssueAfterDisMin { get; set; }

        [Column("MANUALNO")]
        public virtual string? ManualNo { get; set; }

        [Column("NONCOMPLIANCEDESC")]
        public virtual string? NonComplianceDesc { get; set; }

        [Column("PCASENO")]
        public virtual string? PCaseNo { get; set; }

        [Column("PREBILLDATE")]
        public virtual string? PreBillDate { get; set; }

        [Column("PREBILLNO")]
        public virtual string? PreBillNo { get; set; }

        [Column("RECEIPT_ID")]
        public virtual string? receipt_id { get; set; }

        [Column("RECEIPTS_ID")]
        public virtual string? receipts_id { get; set; }

        [Column("SEG_NUMBER")]
        public virtual string? seg_number { get; set; }

        [Column("SUBNO")]
        public virtual long? SubNo { get; set; }

        [ForeignKey("DISCOVERYORGID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? TheDiscoveryOrg { get; set; }

        [ForeignKey("OBJECTSTATEID")]
        public virtual Anu.BaseInfo.DataModel.SystemObject.ObjectState? TheObjectState { get; set; }

        [ForeignKey("PBBILLGEOLOCATIONID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillGeoLocation? ThePBBillGeoLocation { get; set; }

        [ForeignKey("PBBILLSTOREID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBBillStore? ThePBBillStore { get; set; }

        [ForeignKey("PBEXCHANGEUNITID")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBExchangeUnit? ThePBExchangeUnit { get; set; }

        [InverseProperty("ThePBillStore")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStoreProduct>? ThePBillStoreProductList { get; set; }

        [InverseProperty("ThePBillStore")]
        public virtual List<Anu.PunishmentOrg.DataModel.BillStore.PBillStoreUnit>? ThePBillStoreUnitList { get; set; }

        [ForeignKey("PCASEID")]
        public virtual Anu.PunishmentOrg.DataModel.Case.PCase? ThePCase { get; set; }

        [ForeignKey("PDISCOVERYMINUTESID")]
        public virtual Anu.PunishmentOrg.DataModel.DiscoveryMinutes.PDiscoveryMinutes? ThePDiscoveryMinutes { get; set; }

        [ForeignKey("RECEIVERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReceiverUnit { get; set; }

        [ForeignKey("REFERUNITID")]
        public virtual Anu.BaseInfo.DataModel.OrganizationChart.Unit? TheReferUnit { get; set; }

        [Column("TRANSFEREEFAMILY")]
        public virtual string? TransfereeFamily { get; set; }

        [Column("TRANSFEREENAME")]
        public virtual string? TransfereeName { get; set; }

        [Column("TRANSFEREENATIONALCODE")]
        public virtual string? TransfereeNationalCode { get; set; }

        [Column("UNIQUENO")]
        public virtual string? UniqueNo { get; set; }

    }

    [Table("PBILLSTORE")]
    public partial class PBillStore : PBillStoreBase
    {
    }
}