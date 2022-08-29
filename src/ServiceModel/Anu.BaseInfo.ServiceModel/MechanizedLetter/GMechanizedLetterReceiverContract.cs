
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرویس")]
    public class GMechanizedLetterReceiverContract
    {
        public GMechanizedLetterReceiverContract()
        {
            TheGMechanizedLetterReferContractList = new List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterReferContract>();

        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع گيرنده نامه/رونوشت از نظر درون/برون سازماني")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterReceiverType? InnerOrOutterRcvType { get; set; }



        [System.ComponentModel.DisplayName("آيا با سازمان تعامل کننده ارتباط مکانيزه برقرار شده است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsMechanizeRelation { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع گيرنده از نطر گيرنده اصل نامه/رونوشت گيرنده")]
        public Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv? MainRcvOrTranscriptRcv { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع گيرنده نامه/رونوشت از نظر واحدي/سمتي/کاربري")]
        public Anu.BaseInfo.Enumerations.MechanizeRefererType? ReceiverType { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ و ساعت ارسال نامه/رونوشت")]
        public string? SendDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سازماني دروني گيرنده نامه/رونوشت")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSOrganizationContract? TheCMSOrganizationContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سمت گيرنده نامه/رونوشت درون سازماني")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSUserRoleTypeContract? TheCMSUserRoleTypeContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ارجاعات نامه مکانيزه در درون سازمان در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterReferContract>? TheGMechanizedLetterReferContractList { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سازمان بروني گيرنده نامه/رونوشت")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.NAJAUnitContract? TheNAJAUnitContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت-ارسال شده/رويت شده/رويت و ارجاع شده")]
        public string? TheObjectStateContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سمت گيرنده نامه/رونوشت بيرون سازماني")]
        public string? TheReceiverOutOrgPost { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کاربر گيرنده نامه/رونوشت درون سازماني با سمتش")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract? TheReceiverUserAndPost { get; set; }



        [System.ComponentModel.DisplayName("متن رونوشت نامه")]
        public string? TranscriptText { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ رويت")]
        public string? ViewDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ و ساعت رويت نامه/رونوشت")]
        public string? ViewDateTime { get; set; }



        [System.ComponentModel.DisplayName("رويت كننده نامه/رونوشت")]
        public string? ViewerUserName { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("ساعت رويت")]
        public string? ViewTime { get; set; }



    }
}
