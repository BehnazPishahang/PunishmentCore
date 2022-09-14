
using Anu.BaseInfo.DataModel.SystemObject;
using Anu.BaseInfo.ServiceModel.OrganizationChart;
using Anu.BaseInfo.ServiceModel.SystemObject;

namespace Anu.PunishmentOrg.ServiceModel.Accounting
{
    [System.ComponentModel.DisplayName("وضعیت پرداخت در سرویس")]
    public class PBill4PaidInfoContract
    {
        public PBill4PaidInfoContract()
        {
        }
            
            [System.ComponentModel.DisplayName("آیا می تواند پرداخت انجام دهد؟")]
        public bool? CanPay { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضیحات")]
        public string? Desc { get; set; }
        public string? FishNo { get; set; }
        public string? Billtype { get; set; }
        public string? CasesNoSubno { get; set; }
        public string? NationalCode { get; set; }
        public string? UnitName { get; set; }
        public long? TotalPaidCost { get; set; }
        public ObjectStateContract TheObjectStateContract { get; set; }
        public PCasePersonContract ThePCasePersonContract { get; set; }
        public unitContract TheUnitContract { get; set; }
    }
    }
