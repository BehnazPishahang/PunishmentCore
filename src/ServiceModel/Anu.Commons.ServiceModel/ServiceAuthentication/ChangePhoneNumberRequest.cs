namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class ChangePhoneNumberRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? NewPhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? BirthDay { get; set; }
    }

    
}
