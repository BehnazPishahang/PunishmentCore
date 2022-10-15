
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("معترضين در اعتراض موضوع تبصره 1 ماده 21  قانون مبارزه با قاچاق کالا و ارز در سرویس")]
    public class PNote1Article21ProtestPrsContract
    {
        public PNote1Article21ProtestPrsContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني معترض")]
        public string? Address { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي معترض")]
        public string? Family { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام پدر معترض")]
        public string? FatherName { get; set; }

            
            
            [System.ComponentModel.DisplayName("تلفن همراه معترض")]
        public string? MobilNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام معترض")]
        public string? Name { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ملي/شناسه ملي معترض")]
        public string? NationalCode { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع شخص معترض")]
        public Anu.BaseInfo.Enumerations.PersonType? PersonType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("جنسيت معترض")]
        public Anu.BaseInfo.Enumerations.SexType? Sex { get; set; }

            

    }
    }
