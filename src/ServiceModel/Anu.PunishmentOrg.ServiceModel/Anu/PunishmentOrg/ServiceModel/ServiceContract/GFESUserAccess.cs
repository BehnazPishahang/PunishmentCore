﻿
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceModel.ServiceContract
{
    [System.ComponentModel.DisplayName("دسترسي کاربر خارج از سازمان در وب سرويس")]
    public class GFESUserAccess
    {
        public GFESUserAccess()
        {
        }

        
        [System.ComponentModel.DisplayName("از تاريخ و ساعت")]
        public string? FromDateTime { get; set; }


        
        [System.ComponentModel.DisplayName("متن امضاي كاربر")]
        public string? SignText { get; set; }


        
        [System.ComponentModel.DisplayName("تا تاريخ و ساعت")]
        public string? ToDateTime { get; set; }


    }
}
