
namespace Anu.BaseInfo.ServiceModel.Lawyer.LawyerServiceContract
{
    [System.ComponentModel.DisplayName("تاريخچه وضعيت كاري وكيل در سرویس")]
    public class GLawyerWorkHistoryContract
    {
        public GLawyerWorkHistoryContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("از تاريخ")]
        public string? FromDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("پايه وكيل")]
        public Anu.BaseInfo.Enumerations.LawyerDegree? LawyerDegree { get; set; }

            
            
            [System.ComponentModel.DisplayName("وضعيت اشتغال به كار وكيل")]
        public Anu.BaseInfo.Enumerations.LawyerState? LawyerState { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پروانه وكيل")]
        public string? LawyerWorkNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("تا تاريخ")]
        public string? ToDate { get; set; }

            

    }
    }
