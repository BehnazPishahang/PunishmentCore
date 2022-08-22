namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class UserRegisterRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        //[System.ComponentModel.DataAnnotations.Required]
        //public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumber { get; set; }
    }
}
