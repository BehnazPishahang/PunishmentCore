using Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations;

namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class SecondStepUserLoginRequest
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام کاربری الزامی است")]
        [System.ComponentModel.DataAnnotations.MaxLength(3,ErrorMessage = "بیشینه طول نام کاربری 3 است")]
        
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public LoginType? LoginType { get; set; }

        public UserRegisterRequest TheUserRegisterRequest { get; set; }

        public List<UserRegisterRequest> TheUserRegisterRequestList { get; set; }
    }
}
