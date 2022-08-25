using Anu.BaseInfo.Enumerations;

namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class UserRegisterRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? LastName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? BirthDate { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public SexType Sex { get; set; }
    }
}
