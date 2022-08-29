
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("عنوان سازمان تعامل کننده در سرویس")]
    public class GExchangeUnitTitleContract
    {
        public GExchangeUnitTitleContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کد")]
        public string? Code { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آيا با سازمان تعامل کننده ارتباط مکانيزه برقرار شده است؟")]
        public Anu.BaseInfo.Enumerations.YesNo? IsMechanizeRelation { get; set; }



        [System.ComponentModel.DisplayName("لوگوي سازمان تعامل کننده")]
        public byte[]? OrgLogo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }



        [System.ComponentModel.DisplayName("وب سرويس گيرنده نامه مکانيزه")]
        public string? WebServiceFullName { get; set; }



    }
}
