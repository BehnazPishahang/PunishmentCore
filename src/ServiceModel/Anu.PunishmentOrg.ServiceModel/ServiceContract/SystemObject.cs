
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("اشياء سيستم در وب سرويس")]
    public class SystemObject
    {
        public SystemObject()
        {
        }
            
            
            [System.ComponentModel.DisplayName("اسم dll")]
            public string? AssemblyName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("كد")]
            public string? Code { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام انگليسي")]
            public string? EnglishName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("عنوان فارسي")]
            public string? FarsiName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شناسه شيء در ابزار تحليل")]
            public string? RoseId { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع شيء")]
            public Anu.BaseInfo.Enumerations.SystemObjectType SystemObjectType { get; set ;} 
            

    }
    }
