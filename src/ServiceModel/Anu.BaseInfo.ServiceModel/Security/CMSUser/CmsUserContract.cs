
namespace Anu.BaseInfo.ServiceModel.Security.CMSUser
{
    [System.ComponentModel.DisplayName("كاربر در سرویس")]
    public class CmsUserContract
    {
        public CmsUserContract()
        {
        TheRegisterUserHistoryContractList = new List<Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract>();

        }
            
            [System.ComponentModel.DisplayName("تاريخ خاتمه اعتبار كاربر")]
        public string? EndDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? GetFamily { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام")]
        public string? GetName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("متن دسترسي پيشينه كاربر")]
        public string? HstUserSecurityText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("معتبر بودن كاربر")]
        public bool? IsUserValidation { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آخرين تاريخ تغيير كلمه عبور")]
        public string? LastChangePassword { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره همراه جهت ارسال پيام کوتاه")]
        public string? MobileNumber4SMS { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شناسه كاربر")]
        public string? Name { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام و نام خانوادگي قبلي كاربر-قبل از اجباري شدن شماره ملي")]
        public string? OldUserTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كلمه عبور")]
        public string? Password { get; set; }

            
            
            [System.ComponentModel.DisplayName("رشته مورد استفاده در رمزنگاري کلمه عبور")]
        public string? Salt { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ شروع اعتبار كاربر")]
        public string? StartDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("سابقه تنظیمات سمت کاربر در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.SystemConfiguration.RegisterUserHistoryContract>? TheRegisterUserHistoryContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تبديل به متن")]
        public string? ToStringDefault { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ تولد کاربر")]
        public string? UserBirthDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام خانوادگي کاربر")]
        public string? UserFamily { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام پدر کاربر")]
        public string? UserFatherName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا اطلاعات کاربر با ثبت احوال راستي آزمايي شده است؟")]
        public Anu.BaseInfo.Enumerations.CheckNatinalityStatus? UserIsCheckNationalityCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربر")]
        public string? UserName { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ملي کاربر")]
        public string? UserNationalityCode { get; set; }

            
            
            [System.ComponentModel.DisplayName("تصوير کاربر")]
        public byte[]? UserPic { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنسيت کاربر")]
        public Anu.BaseInfo.Enumerations.SexType? UserSex { get; set; }

            
            
            [System.ComponentModel.DisplayName("تصوير امضاء کاربر")]
        public byte[]? UserSignPic { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام و نام خانوادگي كاربر")]
        public string? UserTitle { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مالك شناسه كاربر")]
        public Anu.BaseInfo.Enumerations.UserType? UserType { get; set; }

            

    }
    }
