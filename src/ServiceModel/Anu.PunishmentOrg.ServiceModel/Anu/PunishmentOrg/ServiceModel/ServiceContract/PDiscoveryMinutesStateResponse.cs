
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("خروجي سرويس ارسال آخرين وضعيت صورتجلسه کشف")]
    public class PDiscoveryMinutesStateResponse
    {
        public PDiscoveryMinutesStateResponse()
        {
        }
            
            
            [System.ComponentModel.DisplayName("ساعت خاتمه جلسه رسيدگي")]
            public string? EndTime { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string? PassWord { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("تاريخ وقت")]
            public string? RegisterDate { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت تجديد نظر")]
            public string? RevisionRequest { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ساعت شروع جلسه رسيدگي")]
            public string? StartTime { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string? UniqueNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام واحد")]
            public string? UnitName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("شماره واحد رسيدگي کننده")]
            public string? UnitNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string? UserName { get; set ;} 
            

    }
    }
