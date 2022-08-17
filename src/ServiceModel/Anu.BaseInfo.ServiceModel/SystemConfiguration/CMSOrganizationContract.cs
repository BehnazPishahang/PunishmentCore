
namespace Anu.BaseInfo.ServiceModel.SystemConfiguration
{
    [System.ComponentModel.DisplayName("سازمان مكانيزه در سرویس")]
    public class CMSOrganizationContract
    {
        public CMSOrganizationContract()
        {
            TheRegisterUserHistoryContractList = new List<Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract>();

        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آدرس")]
        public string? Address { get; set; }



        [System.ComponentModel.DisplayName("شماره")]
        public string? CMSOrganizationNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("عنوان")]
        public string? Name { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سابقه تنظیمات سمت کاربر در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract>? TheRegisterUserHistoryContractList { get; set; }



        [System.ComponentModel.DisplayName("واحد سازماني در سرویس")]
        public Anu.BaseInfo.ServiceModel.OrganizationChart.unitContract? TheunitContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }



    }
}
