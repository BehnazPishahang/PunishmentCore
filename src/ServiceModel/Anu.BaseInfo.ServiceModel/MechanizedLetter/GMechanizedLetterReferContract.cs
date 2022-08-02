
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("ارجاعات نامه مکانيزه در درون سازمان در سرویس")]
    public class GMechanizedLetterReferContract
    {
        public GMechanizedLetterReferContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("گيرنده")]
        public string? ReceiveName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع گيرنده")]
        public Anu.BaseInfo.Enumerations.MechanizeRefererType? ReceiverType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوبت ارجاع")]
        public long? ReferNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("دستور نامه/رونوشت توسط ارجاع دهنده")]
        public string? ReferOrder { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ ارجاع")]
        public string? SendDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت ارجاع نامه/رونوشت")]
        public string? SendDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرستنده")]
        public string? SenderName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ساعت ارجاع")]
        public string? SendTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع ارسال به گيرنده")]
        public Anu.BaseInfo.Enumerations.MLetterSendTYpe? SendType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان دروني گيرنده نامه/رونوشت")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSOrganizationContract? TheCMSOrganizationContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سمت گيرنده نامه/رونوشت درون سازماني")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSUserRoleTypeContract? TheCMSUserRoleTypeContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterReceiverContract? TheGMechanizedLetterReceiverContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت-ارسال شده/رويت شده/رويت و ارجاع شده/رويت شده و برگشت داده شده به ارجاع دهنده")]
        public string? TheObjectStateContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کاربر گيرنده نامه/رونوشت درون سازماني با سمتش")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract? TheReceiverUserAndPost { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کاربر فرستنده(ارجاع دهنده) نامه/رونوشت درون سازماني با سمتش")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract? TheSenderUserAndPost { get; set; }

            
            
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
