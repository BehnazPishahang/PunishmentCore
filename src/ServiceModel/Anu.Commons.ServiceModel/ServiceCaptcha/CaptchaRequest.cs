using Anu.Commons.ServiceModel.SeviceRequest;

namespace Anu.Commons.ServiceModel.ServiceCaptcha
{
    public class CaptchaRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public CaptchaInputContract CaptchaContract{ get; set; }

        public CaptchaRequest()
        {
            Request = new Request();
            CaptchaContract = new CaptchaInputContract();
        }
    }
}
