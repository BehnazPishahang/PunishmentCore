
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("مقدار اقلام اطلاعاتي خاص ارسال /دريافت شده با نامه ارسالي/دريافتي از طريق نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetterFields
    {
        public GMechanizedLetterFields()
        {
        }
            
            [System.ComponentModel.DisplayName("مقدار")]
            public long? Amount { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ ثبت درخواست تجديد نظر")]
            public string AppealDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه مدرک مربوط به قلم")]
            public string AttachedId { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره مدرک مربوط به قلم")]
            public string AttachmentDesc { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره پرونده")]
            public string CaseNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شهر")]
            public string City { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مخاطب نامه")]
            public string ContactLetter { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فايل قلم")]
            public byte[] DocFile { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("پسوند فايل قلم")]
            public Anu.BaseInfo.Enumerations.FileExtension DocFileExtention { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شرح")]
            public string FieldDesc { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنس قلم")]
            public Anu.BaseInfo.Enumerations.ChangedFiledDataType FiledDataType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره راي/حکم")]
            public string JudgeNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ دريافت حکم")]
            public string JudgeReceiveDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي نماينده حقوقي")]
            public string LegalRepresentativeFamily { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره موبايل نماينده حقوقي")]
            public long? LegalRepresentativeMobile { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام نماينده حقوقي")]
            public string LegalRepresentativeName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد ملي نماينده حقوقي")]
            public long? LegalRepresentativeNationalityCode { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("سمت مخاطب نامه")]
            public string PostContactLetter { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("استان")]
            public string State { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("موضوع تحديد نظر")]
            public string Subject { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مقدار متني")]
            public string TextAmount { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
            public GMechanizedLetter TheGMechanizedLetter { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("قلم مورد مبادله براي موضوع نامه مکانيزه در وب سرويس مکاتبات مکانيزه")]
            public GMechanizedLetterTypeField TheGMechanizedLetterTypeField { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم هاي سيستم در وب سرويس")]
            public SystemForm TheSystemForm { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشياء سيستم در وب سرويس")]
            public SystemObject TheSystemObject { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوبت")]
            public long? Turn { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره رهگيري سامانه")]
            public string UniqueNo { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شعبه")]
            public string Unit { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string UserName { get; set ;} 
            

    }
    }
