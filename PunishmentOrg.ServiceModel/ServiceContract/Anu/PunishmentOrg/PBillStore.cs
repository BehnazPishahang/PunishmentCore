
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس قبض/رسيد انبار")]
    public class PBillStore
    {
        public PBillStore()
        {
            this.ThePBillStoreProductList = new List<Anu.PunishmentOrg.ServiceContract.PBillStoreProduct>(); 
            this.ThePDiscoveryMinutesList = new List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes>(); 
            this.Thereceipts_idList = new List<Anu.PunishmentOrg.ServiceContract.receipts_id>(); 
        }
            
            [System.ComponentModel.DisplayName("شماره تجميع")]
            public string agg_number { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ قبض/رسيد")]
            public string BillDate { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره قبض/رسيد")]
            public string BillNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ دستور مرجع رسيدگي کننده")]
            public string CourtOrderDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره دستور مرجع رسيدگي کننده")]
            public string CourtOrderNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string CreateDateTime { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ تحويل")]
            public string DeliverDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساعت تحويل")]
            public string DeliverTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي دهنده")]
            public string DeliveryFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام تحويل دهنده")]
            public string DeliveryName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي تحويل دهنده")]
            public string DeliveryNationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه انبارها")]
            public string id_shenaseAnbar { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناساي يکتاي قبض انبار")]
            public string id_shenaseResid { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا کالاهاي تحويلي به سازمان نگه دارنده کالا/ارز مکشوفه با آنچه در صورتجلسه کشف قيد شده، مطابقت دارد؟")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo IsEquality { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا قبض/رسيد پس از صورتجلسه/گزارش کشف اسنادي کشف صادر شده؟")]
            public DataModel.BaseInfo.Anu.Enumerations.YesNo IsIssueAfterDisMin { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره کلاسه")]
            public string ManualNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شرح عدم تطابق کالا/ارز تحويلي با صورتجلسه کشف")]
            public string NonComplianceDesc { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پرونده مربوطه در سازمان رسيدگي کننده")]
            public string PCaseNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ پيش نويس قبض انبار")]
            public string PreBillDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پيش نويس قبض انبار")]
            public string PreBillNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد رهگيري رسيد مادر-تفکيک")]
            public string receipt_id { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره تفکيک")]
            public string seg_number { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرعي")]
            public long? SubNo { get; set ;}

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("دستگاه کاشف")]
            public Anu.PunishmentOrg.ServiceContract.PBExchangeUnit TheDiscoveryOrg { get; set; }

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.ObjectState TheObjectState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("مکان جغرافيايي درسرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBBillGeoLocation ThePBBillGeoLocation { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("انبار نگه داري کالا در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBBillStore ThePBBillStore { get; set ;}

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان تحويل گيرنده")]
            public Anu.PunishmentOrg.ServiceContract.PBExchangeUnit ThePBExchangeUnit { get; set; }

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public List<Anu.PunishmentOrg.ServiceContract.PBillStoreProduct> ThePBillStoreProductList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان داراي دسترسي به قبض/رسيد کالا/ارز صادر شده توسط سازمان مسئول نگه داري کالا/ارز در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBillStoreUnit ThePBillStoreUnit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("پرونده سازمان تعزيرات در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PCase ThePCase { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public List<Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes> ThePDiscoveryMinutesList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ليست کد رهگيري رسيد مادر-تجميع در وب سرويس قبض انبار")]
            public List<Anu.PunishmentOrg.ServiceContract.receipts_id> Thereceipts_idList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.Unit TheReceiverUnit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد ثبتي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.Unit TheReferUnit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي گيرنده")]
            public string TransfereeFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام تحويل گيرنده")]
            public string TransfereeName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ملي تحويل گيرنده")]
            public string TransfereeNationalCode { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string UniqueNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string UserName { get; set ;} 
            

    }
    }
