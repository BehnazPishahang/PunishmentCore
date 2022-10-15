
namespace Anu.PunishmentOrg.ServiceModel.BillStore
{
    [System.ComponentModel.DisplayName("قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
    public class PBillStoreContract
    {
        public PBillStoreContract()
        {
            ThePBillStoreProductContractList = new List<Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreProductContract>();

        }

        [System.ComponentModel.DisplayName("شماره تجميع")]
        public string? agg_number { get; set; }



        [System.ComponentModel.DisplayName("تاريخ قبض/رسيد")]
        public string? BillDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره قبض/رسيد")]
        public string? BillNo { get; set; }



        [System.ComponentModel.DisplayName("تاريخ دستور مرجع رسيدگي کننده")]
        public string? CourtOrderDate { get; set; }



        [System.ComponentModel.DisplayName("شماره دستور مرجع رسيدگي کننده")]
        public string? CourtOrderNo { get; set; }



        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ تحويل")]
        public string? DeliverDate { get; set; }



        [System.ComponentModel.DisplayName("ساعت تحويل")]
        public string? DeliverTime { get; set; }



        [System.ComponentModel.DisplayName("نام خانوادگي دهنده")]
        public string? DeliveryFamily { get; set; }



        [System.ComponentModel.DisplayName("نام تحويل دهنده")]
        public string? DeliveryName { get; set; }



        [System.ComponentModel.DisplayName("شماره ملي تحويل دهنده")]
        public string? DeliveryNationalCode { get; set; }



        [System.ComponentModel.DisplayName("شناسه انبارها")]
        public string? id_shenaseAnbar { get; set; }



        [System.ComponentModel.DisplayName("شناساي يکتاي قبض انبار")]
        public string? id_shenaseResid { get; set; }



        [System.ComponentModel.DisplayName("آيا کالاهاي تحويلي به سازمان نگه دارنده کالا/ارز مکشوفه با آنچه در صورتجلسه کشف قيد شده، مطابقت دارد؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsEquality { get; set; }



        [System.ComponentModel.DisplayName("آيا قبض/رسيد پس از صورتجلسه/گزارش کشف اسنادي کشف صادر شده؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsIssueAfterDisMin { get; set; }



        [System.ComponentModel.DisplayName("شماره کلاسه")]
        public string? ManualNo { get; set; }



        [System.ComponentModel.DisplayName("شرح عدم تطابق کالا/ارز تحويلي با صورتجلسه کشف")]
        public string? NonComplianceDesc { get; set; }



        [System.ComponentModel.DisplayName("شماره پرونده مربوطه در سازمان رسيدگي کننده")]
        public string? PCaseNo { get; set; }



        [System.ComponentModel.DisplayName("تاريخ پيش نويس قبض انبار")]
        public string? PreBillDate { get; set; }



        [System.ComponentModel.DisplayName("شماره پيش نويس قبض انبار")]
        public string? PreBillNo { get; set; }



        [System.ComponentModel.DisplayName("کد رهگيري رسيد مادر-تفکيک")]
        public string? receipt_id { get; set; }



        [System.ComponentModel.DisplayName("ليست کد رهگيري رسيد مادر-تجميع")]
        public string? receipts_id { get; set; }



        [System.ComponentModel.DisplayName("شماره تفکيک")]
        public string? seg_number { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره فرعي")]
        public long? SubNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کالا/ارز قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرویس")]
        public List<Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreProductContract>? ThePBillStoreProductContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ورودی سرویس دریافت قبض انبار")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreServiceRequest? ThePBillStoreServiceRequest { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("خروجی سرویس دریافت قبض انبار")]
        public Anu.PunishmentOrg.ServiceModel.BillStore.PBillStoreServiceResponse? ThePBillStoreServiceResponse { get; set; }



        [System.ComponentModel.DisplayName("نام خانوادگي گيرنده")]
        public string? TransfereeFamily { get; set; }



        [System.ComponentModel.DisplayName("نام تحويل گيرنده")]
        public string? TransfereeName { get; set; }



        [System.ComponentModel.DisplayName("شماره ملي تحويل گيرنده")]
        public string? TransfereeNationalCode { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }



    }
}
