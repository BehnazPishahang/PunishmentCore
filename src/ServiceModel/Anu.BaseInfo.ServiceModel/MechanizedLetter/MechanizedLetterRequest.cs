
namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("MechanizedLetterRequest")]
    public class MechanizedLetterRequest
    {
        public MechanizedLetterRequest()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }

            

    }
    }
