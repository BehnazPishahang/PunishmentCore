
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع واحد اندازه گيري در سرويس")]
    public class MeasurementUnitTypeContarct
    {
        public MeasurementUnitTypeContarct()
        {
        }
            
            
            [System.ComponentModel.DisplayName("کد")]
            public string? Code { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("ميزان/تعدادي از واحد پايه اندازه گيري که با واحد جاري برابري ميکند")]
            public decimal? ExchangeRate { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("نوع کلي واحد")]
            public Anu.BaseInfo.Enumerations.MeasurementUnitType OverallType { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("عنوان")]
            public string? Title { get; set ;} 
            

    }
    }
