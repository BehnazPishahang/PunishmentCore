
namespace Anu.BaseInfo.ServiceModel.Letter.LetterServiceContract
{
    [System.ComponentModel.DisplayName("نامه وارده در سرویس")]
    public class GIncomingLetterContract
    {
        public GIncomingLetterContract()
        {
        }
            
            [System.ComponentModel.DisplayName("پيوست")]
        public string? Attachment { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه هاي بازگشت")]
        public string? BackLettersNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره نامه هاي پيرو")]
        public string? FollowerLettersNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ نامه")]
        public string? LetterDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره نامه")]
        public string? LetterNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن نامه")]
        public string? LetterText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره مکانيزه")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن رسيد نامه")]
        public string? ReceiveLetterText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرستنده")]
        public string? Sender { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع فرستنده")]
        public Anu.BaseInfo.Enumerations.IncommingLetterSenderType? SenderType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ارسال از طريق اينترنت")]
        public Anu.BaseInfo.Enumerations.YesNo? SendViaInternet { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.IncomingLetterState? State { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فوريت نامه")]
        public Anu.BaseInfo.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ ثبت وصول")]
        public string? ViewDate { get; set; }

            

    }
    }
