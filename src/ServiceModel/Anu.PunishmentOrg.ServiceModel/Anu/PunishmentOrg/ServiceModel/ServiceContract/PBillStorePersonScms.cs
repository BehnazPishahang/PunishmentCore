
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
    public class PBillStorePersonScms
    {
        public PBillStorePersonScms()
        {
            this.ThePBillStorePersonScmsList = new List<PBillStorePersonScms>(); 
        }
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string? FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string? Fname { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string? Lname { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد ملي")]
            public string? NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع شخص")]
            public long? PersonTypeId { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام نقش")]
            public string? RoleNameEN { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ورودي سرويس قبض انبار از سامانه سمپق")]
            public PBillStoreFromScms? ThePBillStoreFromScms { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
            public List<PBillStorePersonScms> ThePBillStorePersonScmsList { get; set ;} 
            

    }
    }
