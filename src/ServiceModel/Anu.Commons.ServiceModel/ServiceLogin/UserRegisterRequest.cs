namespace Anu.Commons.ServiceModel.ServiceLogin
{
    public class UserRegisterRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PassWord { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumber { get; set; }
    }
}
