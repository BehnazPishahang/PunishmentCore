
namespace Anu.PunishmentOrg.ServiceModel.InspectionReport
{
    [System.ComponentModel.DisplayName("کالاهاي موضوع  واحد صنفي در گشت سيار در سرویس")]
    public class PMobilePatrolsTUProductContract
    {
        public PMobilePatrolsTUProductContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تعداد/مقدار کالا/ارز تحويل گرفته شده توسط سازمان تحويل گيرنده")]
        public decimal? BillStoreProductValue { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت فروش")]
        public long? SalePrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("قيمت کارشناسي/مصوب")]
        public long? StandardPrice { get; set; }

            
            
            [System.ComponentModel.DisplayName("ارزش تخلف")]
        public long? ViolationPrice { get; set; }

            

    }
    }
