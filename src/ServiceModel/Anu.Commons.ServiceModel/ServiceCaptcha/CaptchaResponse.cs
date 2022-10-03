using Anu.Commons.ServiceModel.ServiceResponse;

namespace Anu.Commons.ServiceModel.ServiceCaptcha
{
    public class CaptchaResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public CaptchaContract CaptchaContract{ get; set; }

        public CaptchaResponse()
        {
            Result = new Result();
            CaptchaContract = new CaptchaContract();
        }
    }
}
