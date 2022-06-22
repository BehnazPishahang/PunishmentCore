
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سايرضمائم و مدارک صورتجلسه/گزارش کشف قاچاق در سرويس")]
    public class PDiscoveryMinutesAttach
    {
        public PDiscoveryMinutesAttach()
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
            public DataModel.BaseInfo.Anu.Enumerations.FileExtension FileExtension { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? OrderNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ساير اطلاعات ضميمه")]
            public string OtherData { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تعداد اوراق")]
            public long? PageNum { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مسير و نام فايل پيوست بر روي حافظه جانبي/شناسه فايل در سامانه مديريت سند")]
            public string PathAndFileName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("وضعيت پردازش پيوست")]
            public DataModel.BaseInfo.Anu.Enumerations.AttachmentProcessState ProcessState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نحوه ذخيره فايل پيوست")]
            public DataModel.BaseInfo.Anu.Enumerations.SaveAttachmentType SaveAttachmentType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("ثانيه و ميلي ثانيه ثبت با فرمت SS:MS")]
            public string SecondMili { get; set ;} 
            
            
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
