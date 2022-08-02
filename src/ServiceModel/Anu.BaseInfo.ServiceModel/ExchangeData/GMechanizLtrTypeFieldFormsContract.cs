
namespace Anu.BaseInfo.ServiceModel.ExchangeData
{
    [System.ComponentModel.DisplayName("فرم هاي و يا اقلام اطلاعاتي معتبر مربوط به مدرک مکانيزه ذيل پرونده(يا مدرک اصلي مشابه آن) در سرویس")]
    public class GMechanizLtrTypeFieldFormsContract
    {
        public GMechanizLtrTypeFieldFormsContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نام انگليسي قلم اطلاعاتي در کلاس مربوط به مقداردهي قلم، که مقدار قلم از آن پر مي شود")]
        public string? AttributeEnglishName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام انگليسي قلم اطلاعاتي در کلاس واسط ويا کلاس مربوط به قلم، که شناسه پرونده(يا مدرک اصلي مشابه آن) در آن قرار دارد و عامل ارتباط با کلاس پرونده(يا مدرک اصلي مشابه) است")]
        public string? RelationAttributeEnglishName { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام انگليسي قلم اطلاعاتي در کلاس واسط که عامل ارتباط با کلاس مربوط به قلم است")]
        public string? RelationAttributeWithRelClass { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("قلم مورد مبادله براي موضوع نامه مکانيزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.ExchangeData.GMechanizedLetterTypeFieldContract? TheGMechanizedLetterTypeFieldContract { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلاس اصلي مربوط به مدرک معتبر يا کلاسي که مقدار قلم از آن مي آيد")]
        public string? TheMainClass { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلاس عامل ارتباط کلاس مربوط به قلم با کلاس پرونده(يا مدرک اصلي مشابه)")]
        public string? TheRelatedClass { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("فرم هاي سيستم در سرویس")]
        public string? TheSystemFormContract { get; set; }

            

    }
    }
