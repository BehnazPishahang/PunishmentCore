
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
    public class GMechanizedLetterContract
    {
        public GMechanizedLetterContract()
        {
            TheGMechanizedLetterCaseContractList = new List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterCaseContract>();

            TheGMechanizedLetterFieldsContractList = new List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterFieldsContract>();

            TheGMechanizedLetterReceiverContractList = new List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterReceiverContract>();

            TheGMechanizedLetterRelLettersContractList = new List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterRelLettersContract>();

        }

        [System.ComponentModel.DisplayName("شماره پرونده ها/مدرک اصلي هاي مربوطه")]
        public string? CasesMainDocNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ ثبت")]
        public string? CreateDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ساعت ثبت")]
        public string? CreateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كاربر ثبت كننده نامه")]
        public string? CreatorUserName { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آيا نامه از برون سازمان گرفته شده است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsSendByOuterOrg { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("متن نامه")]
        public string? LetterText { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نمايش متن")]
        public string? LetterTextHtml { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره نامه/شماره مکانيزه براي نامه دريافتي از برون سازمان")]
        public string? No { get; set; }



        [System.ComponentModel.DisplayName("تاريخ نامه فرستنده برون سازماني")]
        public string? OuterOrgLetterDate { get; set; }



        [System.ComponentModel.DisplayName("شماره نامه فرستنده برون سازماني")]
        public string? OuterOrgLetterNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ ارسال")]
        public string? SendDate { get; set; }



        [System.ComponentModel.DisplayName("كاربر امضاء كننده نامه")]
        public string? SignerLetterUserName { get; set; }



        [System.ComponentModel.DisplayName("فرستنده نامه درون سازماني")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSOrganizationContract? TheCMSOrganizationContract { get; set; }



        [System.ComponentModel.DisplayName("دسترسی کاربر خارج از سازمان در سرویس")]
        public Anu.BaseInfo.ServiceModel.FrontEndSecurity.GFESUserAccessContract? TheGFESUserAccessContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterCaseContract>? TheGMechanizedLetterCaseContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("مقدار اقلام اطلاعاتي خاص ارسال /دريافت شده با نامه ارسالي/دريافتي از طريق نامه مکانيزه در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterFieldsContract>? TheGMechanizedLetterFieldsContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterReceiverContract>? TheGMechanizedLetterReceiverContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نامه جاري")]
        public List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterRelLettersContract>? TheGMechanizedLetterRelLettersContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع موضوع نامه مکانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizedLetterTypeContract? TheGMechanizedLetterTypeContract { get; set; }



        [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheNAJAUnitContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت اشياء در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemObject.ObjectStateContract? TheObjectStateContract { get; set; }



        [System.ComponentModel.DisplayName("سابقه تنظیمات سمت کاربر در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract? TheRegisterUserHistoryContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }



    }
}
