
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ارجاعات نامه مکانيزه در درون سازمان در وب سرويس دريافت مکاتبات")]
    public class GMechanizedLetterRefer
    {
        public GMechanizedLetterRefer()
        {
            this.TheGMechanizedLetterReceiverList = new List<GMechanizedLetterReceiver>(); 
        }
            
            [System.ComponentModel.DisplayName("نوع گيرنده")]
            public Anu.BaseInfo.Enumerations.MechanizeRefererType ReceiverType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوبت ارجاع")]
            public long? ReferNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("دستور نامه/رونوشت توسط ارجاع دهنده")]
            public string? ReferOrder { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تاريخ و ساعت ارجاع نامه/رونوشت")]
            public string? SendDateTime { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع ارسال به گيرنده")]
            public Anu.BaseInfo.Enumerations.MLetterSendTYpe SendType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("گيرنده نامه مکانيزه در سرويس دريافت مکاتبات مکانيزه")]
            public List<GMechanizedLetterReceiver> TheGMechanizedLetterReceiverList { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت اشيا در سرويس")]
            public ObjectState TheObjectState { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
            public CMSOrganization TheReceiverOrg { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع سمت كاربر در وب سرويس")]
            public CMSUserRoleType TheReceiverRoleType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
            public RegisterUserHistory TheReceiverUserAndPost { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("سابقه کاربر در وب سرويس")]
            public RegisterUserHistory TheSenderUserAndPost { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تاريخ و ساعت رويت نامه/رونوشت")]
            public string? ViewDateTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("رويت كننده نامه/رونوشت")]
            public string? ViewerUserName { get; set ;} 
            

    }
    }
