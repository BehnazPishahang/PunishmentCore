
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("سازمان مكانيزه در وب سرويس ")]
    public class CMSOrganization
    {
        public CMSOrganization()
        {
        }
            
            
            [System.ComponentModel.DisplayName("آدرس")]
            public string? Address { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره")]
            public string? CMSOrganizationNo { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("كد")]
            public string? Code { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("عنوان")]
            public string? Name { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            

    }
    }
