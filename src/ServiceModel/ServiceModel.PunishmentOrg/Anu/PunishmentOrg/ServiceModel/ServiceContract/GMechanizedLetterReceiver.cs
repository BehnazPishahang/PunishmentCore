
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
    public class GMechanizedLetterReceiver
    {
        public GMechanizedLetterReceiver()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع گيرنده نامه/رونوشت از نظر درون/برون سازماني")]
            public Anu.BaseInfo.Enumerations.MechanizedLetterReceiverType InnerOrOutterRcvType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("آيا با سازمان تعامل کننده ارتباط مکانيزه برقرار شده است؟")]
            public Anu.BaseInfo.Enumerations.YesNo IsMechanizeRelation { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع گيرنده از نطر گيرنده اصل نامه/رونوشت گيرنده")]
            public Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv MainRcvOrTranscriptRcv { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع گيرنده نامه/رونوشت از نظر واحدي/سمتي/کاربري")]
            public Anu.BaseInfo.Enumerations.MechanizeRefererType ReceiverType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت ارسال نامه/رونوشت")]
            public string SendDateTime { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس دريافت مکاتبات مکانيزه")]
            public GMechanizedLetter TheGMechanizedLetter { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارجاعات نامه مکانيزه در درون سازمان در وب سرويس دريافت مکاتبات")]
            public GMechanizedLetterRefer TheGMechanizedLetterRefer { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
            public ObjectState TheObjectState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
            public CMSOrganization TheReceiverInnerOrg { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع دسترسي کاربر خارج از سازمان در وب سرويس")]
            public GFESUserAccessType TheReceiverOutOrgPost { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("واحد هاي سازماني ساير سازمان ها در وب سرويس")]
            public NAJAUnit TheReceiverOutterOrg { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع سمت كاربر در وب سرويس")]
            public CMSUserRoleType TheReceiverPost { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
            public RegisterUserHistory TheReceiverUserAndPost { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("متن رونوشت نامه")]
            public string TranscriptText { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت رويت نامه/رونوشت")]
            public string ViewDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("رويت كننده نامه/رونوشت")]
            public string ViewerUserName { get; set ;} 
            

    }
    }
