
using Anu.BaseInfo.Enumerations;

namespace Anu.BaseInfo.ServiceModel.Attachment
{
    [System.ComponentModel.DisplayName("پیوست مدارک مکانیزه در سرویس")]
    public class GAttachmentContract
    {
        public GAttachmentContract()
        {
        }

        [System.ComponentModel.DisplayName("تاريخ مدرک پيوست")]
        public string? AttachmentDocDate { get; set; }



        [System.ComponentModel.DisplayName("شماره مدرک پيوست")]
        public string? AttachmentDocNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DisplayName("پسوند فايل")]
        public FileExtension? FileExtension { get; set; }



        [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? OrderNo { get; set; }



        [System.ComponentModel.DisplayName("ساير اطلاعات ضميمه")]
        public string? OtherData { get; set; }



        [System.ComponentModel.DisplayName("تعداد اوراق")]
        public long? PageNum { get; set; }



        [System.ComponentModel.DisplayName("مسير و نام فايل پيوست بر روي حافظه جانبي/شناسه فايل در سامانه مديريت سند")]
        public string? PathAndFileName { get; set; }



        [System.ComponentModel.DisplayName("وضعيت پردازش پيوست")]
        public AttachmentProcessState? ProcessState { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نحوه ذخيره فايل پيوست")]
        public SaveAttachmentType? SaveAttachmentType { get; set; }



        [System.ComponentModel.DisplayName("ثانيه و ميلي ثانيه ثبت با فرمت SS:MS")]
        public string? SecondMili { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع سند یا پیوست در سرویس")]
        public Anu.BaseInfo.ServiceModel.Types.AttachmentTypeContract? TheAttachmentTypeContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("فایل پیوست مدرک مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.Attachment.GAttachmentDataContract? TheGAttachmentDataContract { get; set; }




        [System.ComponentModel.DisplayName("عنوان ضميمه")]
        public string? Title { get; set; }



    }
}
