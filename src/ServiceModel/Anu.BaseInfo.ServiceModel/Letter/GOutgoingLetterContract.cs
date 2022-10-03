namespace Anu.BaseInfo.ServiceModel.Letter
{
    [System.ComponentModel.DisplayName("نامه صادره در سرویس")]
    public class GOutgoingLetterContract
    {
        public GOutgoingLetterContract()
        {
        }

        [System.ComponentModel.DisplayName("پيوست")]
        public string? Attachment { get; set; }



        [System.ComponentModel.DisplayName("شماره نامه هاي بازگشت")]
        public string? BackLettersNo { get; set; }



        [System.ComponentModel.DisplayName("تاريخ تاييد")]
        public string? ConfirmedDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DisplayName("شرح")]
        public string? Description { get; set; }



        [System.ComponentModel.DisplayName("شماره نامه هاي پيرو")]
        public string? FollowerLettersNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آيا نامه چاپ شده")]
        public Enumerations.YesNo? IsPrinted { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ نامه")]
        public string? LetterOutputDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("متن نامه")]
        public string? LetterText { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }



        [System.ComponentModel.DisplayName("تاريخ چاپ نامه")]
        public string? PrintDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("گيرنده")]
        public string? Reciever { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نوع گيرنده")]
        public Enumerations.OutgoingLetterRecieverType? RecieverType { get; set; }



        [System.ComponentModel.DisplayName("تاريخ ثبت جهت تاييد")]
        public string? RegisteredDate { get; set; }



        [System.ComponentModel.DisplayName("تاريخ ارسال")]
        public string? SendedDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت")]
        public Enumerations.OutgoingLetterState? State { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("فوريت نامه")]
        public Enumerations.UrgencyLetter? UrgencyLetter { get; set; }



    }
}
