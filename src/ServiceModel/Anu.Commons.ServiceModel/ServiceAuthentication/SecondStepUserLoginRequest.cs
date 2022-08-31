using Anu.Commons.ServiceModel.ServiceAuthentication.Enumerations;

namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class SecondStepUserLoginRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public LoginType? LoginType { get; set; }
    }
}
