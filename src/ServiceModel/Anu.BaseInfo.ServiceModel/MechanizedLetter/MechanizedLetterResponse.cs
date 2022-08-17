
using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.BaseInfo.ServiceModel.MechanizedLetter
{
    [System.ComponentModel.DisplayName("MechanizedLetterResponse")]
    public class MechanizedLetterResponse: IResponseMessage
    {
        public Result Result { get; set; }
        public MechanizedLetterResponse()
        {
            Result = new Result();
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نامه مکانیزه در سرویس")]
        public Anu.BaseInfo.ServiceModel.MechanizedLetter.GMechanizedLetterContract? TheGMechanizedLetterContract { get; set; }



    }
}
