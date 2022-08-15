namespace Anu.Commons.ServiceModel.ServiceLogin
{
    public class UserLoginRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        //[System.ComponentModel.DataAnnotations.Required]
        //public string? PhoneNumber { get; set; }
    }
}
