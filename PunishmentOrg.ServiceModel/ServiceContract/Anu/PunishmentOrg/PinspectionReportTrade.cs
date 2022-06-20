
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع واحد صنفي گزارش بازرسي در سرويس")]
    public class PinspectionReportTrade
    {
        public PinspectionReportTrade()
        {
        }
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع واحد صنفي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PBTradeUnitType ThePBTradeUnitType { get; set ;} 
            

    }
    }
