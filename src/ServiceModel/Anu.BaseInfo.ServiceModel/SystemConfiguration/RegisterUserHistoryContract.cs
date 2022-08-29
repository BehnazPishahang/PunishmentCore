
namespace Anu.BaseInfo.ServiceModel.SystemConfiguration
{
    [System.ComponentModel.DisplayName("سابقه تنظیمات سمت کاربر در سرویس")]
    public class RegisterUserHistoryContract
    {
        public RegisterUserHistoryContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("از تاريخ")]
        public string? FromDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("از تاريخ و ساعت")]
        public string? FromDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("از ساعت")]
        public string? FromTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("متن امضاي كاربر")]
        public string? SignText { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("سازمان مكانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSOrganizationContract? TheCMSOrganizationContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كاربر در سرویس")]
        public Anu.BaseInfo.ServiceModel.Security.CMSUser.CmsUserContract? TheCmsUserContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع سمت كاربر در سرویس")]
        public Anu.BaseInfo.ServiceModel.SystemConfiguration.CMSUserRoleTypeContract? TheCMSUserRoleTypeContract { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تا تاريخ")]
        public string? ToDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تا تاريخ و ساعت")]
        public string? ToDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تا ساعت")]
        public string? ToTime { get; set; }



    }
}
