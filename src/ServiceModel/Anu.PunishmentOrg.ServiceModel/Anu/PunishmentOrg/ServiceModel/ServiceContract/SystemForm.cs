
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("فرم هاي سيستم در وب سرويس")]
    public class SystemForm
    {
        public SystemForm()
        {
        }
            
            [System.ComponentModel.DisplayName("اسم dll")]
            public string? AssemblyName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("مسير و نام فرم")]
            public string? ClassName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("كد")]
            public string? Code { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام انگليسي فرم")]
            public string? EnglishName { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نام فارسي فرم")]
            public string? FarsiName { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("رديف در FormDesigner")]
            public string? FormDesignerId { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فرم هاي قابل رويت در فرم جاري")]
            public string? FromVisibleInForm { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("فعاليت شروع شونده")]
            public string? WorkFlowStarter { get; set ;} 
            

    }
    }
