
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("پيوست هاي گزارش بازرسي در سرويس")]
    public class PInspectionReportAttachment
    {
        public PInspectionReportAttachment()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ مدرک پيوست")]
            public string AttachmentDocDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره مدرک پيوست")]
            public string AttachmentDocNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
            public string CreateDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فايل پيوست")]
            public byte[] DocFile { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پسوند فايل")]
            public Anu.BaseInfo.Enumerations.FileExtension FileExtension { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? OrderNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير اطلاعات ضميمه")]
            public string OtherData { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد اوراق")]
            public long? PageNum { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مسير و نام فايل پيوست بر روي حافظه جانبي/شناسه فايل در سامانه مديريت سند")]
            public string PathAndFileName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت پردازش پيوست")]
            public Anu.BaseInfo.Enumerations.AttachmentProcessState ProcessState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه ذخيره فايل پيوست")]
            public Anu.BaseInfo.Enumerations.SaveAttachmentType SaveAttachmentType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ثانيه و ميلي ثانيه ثبت با فرمت SS:MS")]
            public string SecondMili { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع سند يا پيوست در سرويس")]
            public AttachmentType TheAttachmentType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس گزارش بازرسي")]
            public PInspectionReport ThePInspectionReport { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عنوان ضميمه")]
            public string Title { get; set ;} 
            

    }
    }
