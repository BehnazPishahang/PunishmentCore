
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("اسناد،اوراق و وسايل کشف شده صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesDocFound
    {
        public PDiscoveryMinutesDocFound()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ مدرک پيوست")]
            public string AttachmentDocDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره مدرک پيوست")]
            public string AttachmentDocNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده ارز")]
            public string BillNoDocFound { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره يا مشخصه")]
            public string Characteristic { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره يا مشخصه")]
            public Anu.Enumerations.PunishmentOrg.CharacteristicDoc CharacteristicRN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد")]
            public long? Count { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string CreateDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("توضيحات")]
            public string Description { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن توضيحات")]
            public Anu.Enumerations.PunishmentOrg.DescriptionDoc DescriptionRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فايل پيوست")]
            public byte[] DocFile { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("صادر کننده")]
            public string Exporter { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پسوند فايل")]
            public Anu.Enumerations.FileExtension FileExtension { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ صدور")]
            public string IssuingDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تاريخ صدور")]
            public Anu.Enumerations.PunishmentOrg.IssuingDateDoc IssuingDateRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? OrderNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير اطلاعات ضميمه")]
            public string OtherData { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مالک ")]
            public string Owner { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن مالک ")]
            public Anu.Enumerations.PunishmentOrg.OwnerDoc OwnerRN { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد اوراق")]
            public long? PageNum { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مسير و نام فايل پيوست بر روي حافظه جانبي/شناسه فايل در سامانه مديريت سند")]
            public string PathAndFileName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت پردازش پيوست")]
            public Anu.Enumerations.AttachmentProcessState ProcessState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه ذخيره فايل پيوست")]
            public Anu.Enumerations.SaveAttachmentType SaveAttachmentType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ثانيه و ميلي ثانيه ثبت با فرمت SS:MS")]
            public string SecondMili { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string SubjectTitle { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع سند يا پيوست در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.AttachmentType TheAttachmentType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public Anu.PunishmentOrg.ServiceContract.PDiscoveryMinutes ThePDiscoveryMinutes { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان ضميمه")]
            public string Title { get; set ;} 
            

    }
    }
