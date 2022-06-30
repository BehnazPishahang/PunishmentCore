
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("ورودي سرويس قبض انبار از سامانه سمپق")]
    public class PBillStoreFromScms
    {
        public PBillStoreFromScms()
        {
            this.ThePBillStorePersonScmsList = new List<PBillStorePersonScms>(); 
        }
            
            [System.ComponentModel.DisplayName("تاريخ قبض")]
            public string BillDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره قبض انبار")]
            public string BillNumber { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کدينگ دستگاه کاشف")]
            public string CodingDeviceDetector { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه يکتاي پرونده")]
            public string ParentContentNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string PassWord { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره صورتجلسه")]
            public string ProceedingNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
            public List<PBillStorePersonScms> ThePBillStorePersonScmsList { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه سامانه جامع انبارها")]
            public string TrackingCodeStores { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string UserName { get; set ;} 
            

    }
    }
