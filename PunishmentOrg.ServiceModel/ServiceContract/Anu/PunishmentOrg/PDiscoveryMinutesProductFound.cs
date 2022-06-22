
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ارز/کالاهاي مکشوفه صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesProductFound
    {
        public PDiscoveryMinutesProductFound()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده کالا")]
            public string BillNoProductFound { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
            public string BrandName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام تجاري(برند)")]
            public DataModel.Anu.Enumerations.PunishmentOrg.BrandName BrandNameRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد کالا/تعداد قطعات ارز")]
            public decimal? Count { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کشور سازنده")]
            public string CountryCreate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کشور سازنده")]
            public DataModel.Anu.Enumerations.PunishmentOrg.CountryCreate CountryCreateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
            public string CurrencyUnit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
            public long? CurrencyValue { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارزش تخميني")]
            public decimal? EstimatedValue { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
            public string IDNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شناسه")]
            public DataModel.Anu.Enumerations.PunishmentOrg.IDNumber IDNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
            public string OtherInfo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کالا/ارز کشف شده")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PProductOrCurrency ProductOrCurrency { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع کالاي کشف شده")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PProductType ProductType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سريال")]
            public string SerialNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن سريال")]
            public DataModel.Anu.Enumerations.PunishmentOrg.SerialNumber SerialNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کالا/ نوع ارز")]
            public string SubjectTitle { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع واحد اندازه گيري در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.MeasurementUnitType TheMeasurementUnitType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع واحد اندازه گيري سازمان تعامل کننده در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBBillMeasurementUnitType ThePBBillMeasurementUnitType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("گروه کالا/ارز سازمان تعامل کننده در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBBillProductGrp ThePBBillProductGrp { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع کالا/ارز/خدمات در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBProductCurrencyType ThePBProductCurrencyType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
