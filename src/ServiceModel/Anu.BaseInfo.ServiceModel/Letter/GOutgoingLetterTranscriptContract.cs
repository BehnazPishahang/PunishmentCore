namespace Anu.BaseInfo.ServiceModel.Letter
{
    [System.ComponentModel.DisplayName("رونوشت هاي نامه صادره در سرویس")]
    public class GOutgoingLetterTranscriptContract
    {
        public GOutgoingLetterTranscriptContract()
        {
        }

        [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نحوه ارسال")]
        public Enumerations.TranscriptSendType? SendType { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("متن رونوشت")]
        public string? TranscriptText { get; set; }



    }
}
