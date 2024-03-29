﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع کالا/ارز/خدمات در سرويس")]
    public class PBProductCurrencyType
    {
        public PBProductCurrencyType()
        {
        }
            
            
            [System.ComponentModel.DisplayName("کد")]
            public string? Code { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کد سطح کالا/ارز/خدمات")]
            public string? LevelCode { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("کالا/ارز/خدمات")]
            public Anu.PunishmentOrg.Enumerations.PUProductCurrency ProductCurrency { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("وضعيت")]
            public Anu.BaseInfo.Enumerations.State State { get; set ;} 
            
            
            
            [System.ComponentModel.DisplayName("عنوان")]
            public string? Title { get; set ;} 
            

    }
    }
