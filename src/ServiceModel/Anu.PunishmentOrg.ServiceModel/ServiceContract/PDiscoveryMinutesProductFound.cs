
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ارز/کالاهاي مکشوفه صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesProductFound
    {
        public PDiscoveryMinutesProductFound()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده کالا")]
            public string? BillNoProductFound { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام تجاري(برند)")]
            public string? BrandName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن نام تجاري(برند)")]
            public Anu.PunishmentOrg.Enumerations.BrandName BrandNameRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تعداد کالا/تعداد قطعات ارز")]
            public decimal? Count { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کشور سازنده")]
            public string? CountryCreate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن کشور سازنده")]
            public Anu.PunishmentOrg.Enumerations.CountryCreate CountryCreateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("واحد قطعات ارز")]
            public string? CurrencyUnit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ميزان ارز")]
            public long? CurrencyValue { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ارزش تخميني")]
            public decimal? EstimatedValue { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه کالا")]
            public string? IDNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شناسه")]
            public Anu.PunishmentOrg.Enumerations.IDNumber IDNumberRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير مشخصات")]
            public string? OtherInfo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کالا/ارز کشف شده")]
            public Anu.PunishmentOrg.Enumerations.PProductOrCurrency ProductOrCurrency { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع کالاي کشف شده")]
            public Anu.PunishmentOrg.Enumerations.PProductType ProductType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سريال")]
            public string? SerialNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن سريال")]
            public Anu.PunishmentOrg.Enumerations.SerialNumber SerialNumberRN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام کالا/ نوع ارز")]
            public string? SubjectTitle { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع واحد اندازه گيري در سرويس")]
            public MeasurementUnitTypeContarct TheMeasurementUnitType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع واحد اندازه گيري سازمان تعامل کننده در سرويس")]
            public PBBillMeasurementUnitType ThePBBillMeasurementUnitType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("گروه کالا/ارز سازمان تعامل کننده در سرويس")]
            public PBBillProductGrp ThePBBillProductGrp { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع کالا/ارز/خدمات در سرويس")]
            public PBProductCurrencyType ThePBProductCurrencyType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            

    }
    }
