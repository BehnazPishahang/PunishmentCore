namespace Anu.BaseInfo.ServiceModel.Letter
{
    [System.ComponentModel.DisplayName("پرونده يا مدرک هاي مربوطه نامه وارده در سرویس")]
    public class GIncomingLetterCaseContract
    {
        public GIncomingLetterCaseContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت پرونده")]
        public Enumerations.CaseMechanizeState? CaseMechanizeState { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت مالکيت نامه")]
        public Enumerations.CaseOwner? CaseOwner { get; set; }



        [System.ComponentModel.DisplayName("شناسه پرونده يا مدرک مربوطه")]
        public string? RelatedCaseID { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پرونده يا مدرک مربوطه نامه")]
        public string? RelatedCaseNo { get; set; }



        [System.ComponentModel.DisplayName("عنوان/شرح پرونده يا مدرک مربوطه نامه")]
        public string? RelatedCaseTitle { get; set; }



    }
}
