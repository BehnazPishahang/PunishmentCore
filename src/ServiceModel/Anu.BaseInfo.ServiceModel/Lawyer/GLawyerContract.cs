namespace Anu.BaseInfo.ServiceModel.Lawyer
{
    [System.ComponentModel.DisplayName("وکيل در سرویس")]
    public class GLawyerContract
    {
        public GLawyerContract()
        {
        }

        [System.ComponentModel.DisplayName("تاريخ تولد")]
        public string? CreateDate { get; set; }



        [System.ComponentModel.DisplayName("آدرس پست الکترونيکي")]
        public string? EMailAddress { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ پايان اعتبار پروانه")]
        public string? EndCreditLicenseDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("تاريخ پايان تعليق")]
        public string? EndDate { get; set; }



        [System.ComponentModel.DisplayName("تاريخ پايان کارآموزي")]
        public string? EndNovitiateDate { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام خانوادگي")]
        public string? Family { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام پدر")]
        public string? FatherName { get; set; }



        [System.ComponentModel.DisplayName("نشاني منزل")]
        public string? HomeAddress { get; set; }



        [System.ComponentModel.DisplayName("شماره شناسنامه")]
        public string? IdentityNo { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آيا وکيل حذف شده")]
        public Enumerations.YesNo? IsDeleted { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نشاني محل كار")]
        public string? JobAddress { get; set; }



        [System.ComponentModel.DisplayName("تلفن محل كار")]
        public string? JobTel { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("پايه وكيل")]
        public Enumerations.LawyerDegree? LawyerDegree { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("وضعيت اشتغال به كار وكيل")]
        public Enumerations.LawyerState? LawyerState { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("مرجع صدور پروانه وكالت")]
        public Enumerations.LawyerTypeLicense? LawyerTypeLicense { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پروانه وكيل")]
        public string? LawyerWorkNo { get; set; }



        [System.ComponentModel.DisplayName("وضعيت تاهل")]
        public Enumerations.MarriageState? MariageState { get; set; }



        [System.ComponentModel.DisplayName("شماره همراه جهت ارسال پيام کوتاه")]
        public string? MobileNumber4SMS { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام")]
        public string? Name { get; set; }



        [System.ComponentModel.DisplayName("كد ملي")]
        public string? NationalityCode { get; set; }



        [System.ComponentModel.DisplayName("شماره رمز وكيل جهت دسترسي به سايت")]
        public string? PersonPassword { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("جنسيت")]
        public Enumerations.SexType? Sex { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("کليد رکورد وکيل در جدول مبدا")]
        public string? SourceID { get; set; }



        [System.ComponentModel.DisplayName("تلفن منزل")]
        public string? Tel { get; set; }



    }
}
