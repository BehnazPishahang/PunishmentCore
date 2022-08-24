
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("مقدار اقلام اطلاعاتي خاص ارسال /دريافت شده با نامه ارسالي/دريافتي از طريق نامه مکانيزه در سرویس")]
    public class GMechanizedLetterFieldsContract
    {
        public GMechanizedLetterFieldsContract()
        {
        }

        [System.ComponentModel.DisplayName("مقدار")]
        public long? Amount { get; set; }



        [System.ComponentModel.DisplayName("شناسه مدرک مربوط به قلم")]
        public string? AttachedId { get; set; }



        [System.ComponentModel.DisplayName("شماره مدرک مربوط به قلم")]
        public string? AttachmentDesc { get; set; }



        [System.ComponentModel.DisplayName("فايل قلم")]
        public byte[]? DocFile { get; set; }



        [System.ComponentModel.DisplayName("پسوند فايل قلم")]
        public Anu.BaseInfo.Enumerations.FileExtension? DocFileExtention { get; set; }



        [System.ComponentModel.DisplayName("شرح")]
        public string? FieldDesc { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("رشته مربوط به مقدار فيلد فايلي")]
        public string? FieldValFileString { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("جنس قلم")]
        public Anu.BaseInfo.Enumerations.ChangedFiledDataType? FiledDataType { get; set; }



        [System.ComponentModel.DisplayName("مقدار متني")]
        public string? TextAmount { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("قلم مورد مبادله براي موضوع نامه مکانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizedLetterTypeFieldContract? TheGMechanizedLetterTypeFieldContract { get; set; }



        [System.ComponentModel.DisplayName("فرم مربوط به قلم مدرک ذيل پرونده يا مشابه آن")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemFormContract? TheSystemFormContract { get; set; }



        [System.ComponentModel.DisplayName("شيء اصلي مربوط به قلم مدرک ذيل پرونده يا مشابه آن")]
        public Anu.BaseInfo.ServiceModel.SystemObject.SystemObjectContract? TheSystemObjectContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوبت")]
        public long? Turn { get; set; }



    }
}
