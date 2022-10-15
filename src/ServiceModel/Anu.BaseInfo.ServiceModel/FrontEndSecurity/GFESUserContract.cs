
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("کاربر خارج از سازمان در سرویس")]
    public class GFESUserContract
    {
        public GFESUserContract()
        {
        TheGFESUserAccessContractList = new List<Anu.BaseInfo.ServiceModel.FrontEndSecurity.GFESUserAccessContract>();

        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ خاتمه اعتبار كاربر")]
        public string? EndDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آخرين تاريخ تغيير كلمه عبور")]
        public string? LastChangePassword { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره همراه جهت ارسال پيام کوتاه")]
        public string? MobileNumber4SMS { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ملي")]
        public string? NationalityCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كلمه عبور")]
        public string? Password { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنسيت")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع اعتبار كاربر")]
        public string? StartDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("دسترسی کاربر خارج از سازمان در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.FrontEndSecurity.GFESUserAccessContract>? TheGFESUserAccessContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه كاربر")]
        public string? UserID { get; set; }

            

    }
    }
