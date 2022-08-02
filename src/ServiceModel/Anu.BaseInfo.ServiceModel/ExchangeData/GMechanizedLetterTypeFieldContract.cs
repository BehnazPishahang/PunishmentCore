
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("قلم مورد مبادله براي موضوع نامه مکانيزه در سرویس")]
    public class GMechanizedLetterTypeFieldContract
    {
        public GMechanizedLetterTypeFieldContract()
        {
        TheGMechanizLtrTypeFieldFormsContractList = new List<Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizLtrTypeFieldFormsContract>();

        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جنس قلم")]
        public Anu.BaseInfo.Enumerations.ChangedFiledDataType? ChangedFiledDataType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا اجباري است")]
        public Anu.BaseInfo.Enumerations.YesNo? IsMandatory { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع کلي قلم")]
        public Anu.BaseInfo.Enumerations.MechanizedFieldType? MechanizedFieldType { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع موضوع نامه مکانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizedLetterTypeContract? TheGMechanizedLetterTypeContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم هاي و يا اقلام اطلاعاتي معتبر مربوط به مدرک مکانيزه ذيل پرونده(يا مدرک اصلي مشابه آن) در سرویس")]
        public List<Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizLtrTypeFieldFormsContract>? TheGMechanizLtrTypeFieldFormsContractList { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }

            

    }
    }
