
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
            TheObjectStateContract = new ObjectStateContract();
            ThePCasePersonContract = new PCasePersonContract();
            TheUnitContract        = new UnitContract();
        }
            
        [System.ComponentModel.DisplayName("آیا می تواند پرداخت انجام دهد؟")]
        public bool? CanPay { get; set; }
            
        [System.ComponentModel.DisplayName("توضیحات")]
        public string? Desc { get; set; }

        [System.ComponentModel.DisplayName("شماره فیش")]
        public string? FishNo { get; set; }

        [System.ComponentModel.DisplayName("نوع قبض")]
        public string? Billtype { get; set; }

        [System.ComponentModel.DisplayName("شماره پرونده ها/فرعي هاي مربوطه")]
        public string? CasesNoSubno { get; set; }

        [System.ComponentModel.DisplayName("جمع مبلغ دريافتي")]
        public long? TotalPaidCost { get; set; }

        [System.ComponentModel.DisplayName("وضعيت اشياء")]
        public ObjectStateContract TheObjectStateContract { get; set; }

        [System.ComponentModel.DisplayName("شخص پرونده پرداخت کننده وجه")]
        public PCasePersonContract ThePCasePersonContract { get; set; }

        [System.ComponentModel.DisplayName("واحد مربوطه")]
        public UnitContract TheUnitContract { get; set; }
    }
    }
