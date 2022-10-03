
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("علت برگشت گزارش بازرسي به فرستنده در سرویس")]
    public class PInspectionReportRetReasonContract
    {
        public PInspectionReportRetReasonContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("علت برگشت گزارش")]
        public Anu.PunishmentOrg.Enumerations.InspectionReportReturnReason? ReturnReason { get; set; }

            

    }
    }
