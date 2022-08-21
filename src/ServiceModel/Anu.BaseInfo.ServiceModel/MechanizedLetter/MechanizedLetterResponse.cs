
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("MechanizedLetterResponse")]
    public class MechanizedLetterResponse: IResponseMessage
    {
        public Result Result { get; set; }
        public MechanizedLetterResponse()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("آخرین وضعیت مکاتبات مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterOutputContract? TheGMechanizedLetterOutputContract { get; set; }



    }
}
