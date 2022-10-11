namespace Anu.Commons.ServiceModel.ServiceAuthentication
{
    public class ChangePasswordRequest
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? OldPassword { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? NewPassword { get; set; }
        
        [System.ComponentModel.DataAnnotations.Required]
        public string? ConfirmNewPassword { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? SmsCode { get; set; }
    }
}
