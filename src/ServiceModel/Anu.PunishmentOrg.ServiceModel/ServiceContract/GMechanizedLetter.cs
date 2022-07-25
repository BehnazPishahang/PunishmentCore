
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetter
    {
        public GMechanizedLetter()
        {
            this.TheGMechanizedLetterCaseList = new List<GMechanizedLetterCase>();
            this.TheGMechanizedLetterFieldsList = new List<GMechanizedLetterFields>();
            this.TheGMechanizedLetterReceiverList = new List<GMechanizedLetterReceiver>();
            this.TheRelLettersList = new List<GMechanizedLetterRelLetters>();
        }

        [System.ComponentModel.DisplayName("شماره پرونده ها/مدرک اصلي هاي مربوطه")]
        public string? CasesMainDocNo { get; set; }


        
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }


        
        [System.ComponentModel.DisplayName("كاربر ثبت كننده نامه")]
        public string? CreatorUserName { get; set; }


        
        [System.ComponentModel.DisplayName("آيا نامه از برون سازمان گرفته شده است؟")]
        public Anu.BaseInfo.Enumerations.YesNo IsSendByOuterOrg { get; set; }


        
        [System.ComponentModel.DisplayName("متن نامه")]
        public string? LetterText { get; set; }


        
        [System.ComponentModel.DisplayName("شماره نامه/شماره مکانيزه براي نامه دريافتي از برون سازمان")]
        public string? No { get; set; }


        [System.ComponentModel.DisplayName("تاريخ نامه فرستنده برون سازماني")]
        public string? OuterOrgLetterDate { get; set; }


        [System.ComponentModel.DisplayName("شماره نامه فرستنده برون سازماني")]
        public string? OuterOrgLetterNo { get; set; }


        
        [System.ComponentModel.DisplayName("کلمه عبور")]
        public string? PassWord { get; set; }


        [System.ComponentModel.DisplayName("كاربر امضاء كننده نامه")]
        public string? SignerLetterUserName { get; set; }


        
        [System.ComponentModel.DisplayName("دسترسي کاربر خارج از سازمان در وب سرويس")]
        public GFESUserAccess TheGFESUserAccess { get; set; }


        
        [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<GMechanizedLetterCase> TheGMechanizedLetterCaseList { get; set; }


        
        [System.ComponentModel.DisplayName("مقدار اقلام اطلاعاتي خاص ارسال /دريافت شده با نامه ارسالي/دريافتي از طريق نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<GMechanizedLetterFields> TheGMechanizedLetterFieldsList { get; set; }


        
        [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<GMechanizedLetterReceiver> TheGMechanizedLetterReceiverList { get; set; }


        
        [System.ComponentModel.DisplayName("نوع موضوع نامه مکانيزه در وب سرويس")]
        public GMechanizedLetterType TheGMechanizedLetterType { get; set; }


        
        [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
        public ObjectState TheObjectState { get; set; }


        
        [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
        public RegisterUserHistory TheRegisterUserHistory { get; set; }


        
        [System.ComponentModel.DisplayName("نامه هاي بازگشتي/پيروي نامه جاري در وب سرويس دريافت مکاتبات")]
        public List<GMechanizedLetterRelLetters> TheRelLettersList { get; set; }


        
        [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
        public CMSOrganization TheSenderInnerOrg { get; set; }


        
        [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در وب سرويس")]
        public NAJAUnit TheSenderOuterOrg { get; set; }


        [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string? UniqueNo { get; set; }


        
        [System.ComponentModel.DisplayName("نام کاربري")]
        public string? UserName { get; set; }


    }
}
