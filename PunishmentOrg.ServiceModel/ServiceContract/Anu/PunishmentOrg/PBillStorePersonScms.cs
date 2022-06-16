
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
    public class PBillStorePersonScms
    {
        public PBillStorePersonScms()
        {
            this.ThePBillStorePersonScmsList = new List<Anu.PunishmentOrg.ServiceContract.PBillStorePersonScms>(); 
        }
            
            [System.ComponentModel.DisplayName("نام پدر")]
            public string FatherName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام")]
            public string Fname { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string Lname { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("کد ملي")]
            public string NationalCode { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع شخص")]
            public long? PersonTypeId { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نام نقش")]
            public string RoleNameEN { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس قبض انبار از سامانه سمپق")]
            public Anu.PunishmentOrg.ServiceContract.PBillStoreFromScms ThePBillStoreFromScms { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
            public List<Anu.PunishmentOrg.ServiceContract.PBillStorePersonScms> ThePBillStorePersonScmsList { get; set ;} 
            

    }
    }
