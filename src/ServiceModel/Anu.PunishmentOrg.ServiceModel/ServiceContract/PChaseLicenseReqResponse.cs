
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("خروجي سرويس درخواست مجوز تعقيب/بازرسي")]
    public class PChaseLicenseReqResponse
    {
        public PChaseLicenseReqResponse()
        {
        }
            
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string? PassWord { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string? UniqueNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string? UserName { get; set ;} 
            

    }
    }
