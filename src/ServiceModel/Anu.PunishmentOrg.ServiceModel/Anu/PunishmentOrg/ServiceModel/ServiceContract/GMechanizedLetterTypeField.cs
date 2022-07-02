﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("قلم مورد مبادله براي موضوع نامه مکانيزه در وب سرويس مکاتبات مکانيزه")]
    public class GMechanizedLetterTypeField
    {
        public GMechanizedLetterTypeField()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنس قلم")]
            public Anu.BaseInfo.Enumerations.ChangedFiledDataType ChangedFiledDataType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
            public string Code { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا اجباري است")]
            public Anu.BaseInfo.Enumerations.YesNo IsMandatory { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع کلي قلم")]
            public Anu.BaseInfo.Enumerations.MechanizedFieldType MechanizedFieldType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
            public string Title { get; set ;} 
            

    }
    }