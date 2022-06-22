
using System.Collections.Generic;
namespace ServiceModel.PunishmentOrg.ServiceContract.Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("اشياء سيستم در وب سرويس")]
    public class SystemObject
    {
        public SystemObject()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اسم dll")]
            public string AssemblyName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام انگليسي")]
            public string EnglishName { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان فارسي")]
            public string FarsiName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه شيء در ابزار تحليل")]
            public string RoseId { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شيء")]
            public DataModel.BaseInfo.Anu.Enumerations.SystemObjectType SystemObjectType { get; set ;} 
            

    }
    }
