
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("ارجاعات نامه مکانيزه در درون سازمان در وب سرويس دريافت مکاتبات")]
    public class GMechanizedLetterRefer
    {
        public GMechanizedLetterRefer()
        {
            this.TheGMechanizedLetterReceiverList = new List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterReceiver>(); 
        }
            
            [System.ComponentModel.DisplayName("نوع گيرنده")]
            public DataModel.BaseInfo.Anu.Enumerations.MechanizeRefererType ReceiverType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوبت ارجاع")]
            public long? ReferNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دستور نامه/رونوشت توسط ارجاع دهنده")]
            public string ReferOrder { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت ارجاع نامه/رونوشت")]
            public string SendDateTime { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع ارسال به گيرنده")]
            public DataModel.BaseInfo.Anu.Enumerations.MLetterSendTYpe SendType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
            public List<Anu.PunishmentOrg.ServiceContract.GMechanizedLetterReceiver> TheGMechanizedLetterReceiverList { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.ObjectState TheObjectState { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
            public Anu.PunishmentOrg.ServiceContract.CMSOrganization TheReceiverOrg { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع سمت كاربر در وب سرويس")]
            public Anu.PunishmentOrg.ServiceContract.CMSUserRoleType TheReceiverRoleType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
            public Anu.PunishmentOrg.ServiceContract.RegisterUserHistory TheReceiverUserAndPost { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
            public Anu.PunishmentOrg.ServiceContract.RegisterUserHistory TheSenderUserAndPost { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ و ساعت رويت نامه/رونوشت")]
            public string ViewDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("رويت كننده نامه/رونوشت")]
            public string ViewerUserName { get; set ;} 
            

    }
    }
