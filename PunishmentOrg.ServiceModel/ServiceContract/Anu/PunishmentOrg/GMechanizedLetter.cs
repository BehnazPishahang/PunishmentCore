
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetter
    {
        public GMechanizedLetter()
        {
            this.TheGMechanizedLetterCaseList = new List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterCase>();
            this.TheGMechanizedLetterFieldsList = new List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterFields>();
            this.TheGMechanizedLetterReceiverList = new List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterReceiver>();
            this.TheRelLettersList = new List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterRelLetters>();
        }

        [System.ComponentModel.DisplayName("شماره پرونده ها/مدرک اصلي هاي مربوطه")]
        public string CasesMainDocNo { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string CreateDateTime { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كاربر ثبت كننده نامه")]
        public string CreatorUserName { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آيا نامه از برون سازمان گرفته شده است؟")]
        public DataModel.BaseInfo.Anu.Enumerations.YesNo IsSendByOuterOrg { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("متن نامه")]
        public string LetterText { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره نامه/شماره مکانيزه براي نامه دريافتي از برون سازمان")]
        public string No { get; set; }


        [System.ComponentModel.DisplayName("تاريخ نامه فرستنده برون سازماني")]
        public string OuterOrgLetterDate { get; set; }


        [System.ComponentModel.DisplayName("شماره نامه فرستنده برون سازماني")]
        public string OuterOrgLetterNo { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کلمه عبور")]
        public string PassWord { get; set; }


        [System.ComponentModel.DisplayName("كاربر امضاء كننده نامه")]
        public string SignerLetterUserName { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("دسترسي کاربر خارج از سازمان در وب سرويس")]
        public Anu.PunishmentOrg.ServiceContract.GFESUserAccess TheGFESUserAccess { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("پرونده(يا مدرک اصلي مشابه) مربوطه نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterCase> TheGMechanizedLetterCaseList { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("مقدار اقلام اطلاعاتي خاص ارسال /دريافت شده با نامه ارسالي/دريافتي از طريق نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterFields> TheGMechanizedLetterFieldsList { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
        public List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterReceiver> TheGMechanizedLetterReceiverList { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع موضوع نامه مکانيزه در وب سرويس")]
        public Anu.PunishmentOrg.ServiceContract.GMechanizedLetterType TheGMechanizedLetterType { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
        public Anu.PunishmentOrg.ServiceContract.ObjectState TheObjectState { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
        public Anu.PunishmentOrg.ServiceContract.RegisterUserHistory TheRegisterUserHistory { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نامه هاي بازگشتي/پيروي نامه جاري در وب سرويس دريافت مکاتبات")]
        public List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterRelLetters> TheRelLettersList { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
        public Anu.PunishmentOrg.ServiceContract.CMSOrganization TheSenderInnerOrg { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در وب سرويس")]
        public Anu.PunishmentOrg.ServiceContract.NAJAUnit TheSenderOuterOrg { get; set; }


        [System.ComponentModel.DisplayName("شناسه يکتا")]
        public string UniqueNo { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام کاربري")]
        public string UserName { get; set; }


    }
}
