namespace Anu.BaseInfo.ServiceModel.Lawyer
{
    [System.ComponentModel.DisplayName("کانون هاي وکلاي کشور در سرویس")]
    public class GLawyerClubContract
    {
        public GLawyerClubContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public Enumerations.State? State { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }



    }
}
