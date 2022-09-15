
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Sms.ServiceModel;
using Microsoft.Extensions.Configuration;
using Utility.Exceptions;

namespace Anu.Utility.Sms
{
    public static class SmsSender
    {
        private static IConfiguration _configuration;

        public static void GetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static async Task SendSms(string phoneNumber,string message)
        {
            var SendSmsCanUsed = _configuration.GetSection("StatusServices:SendSms").Value;
            if (!Convert.ToBoolean(SendSmsCanUsed))
            {
                return;
            }
            string BaseUrl = "https://sms.magfa.com/api/http/sms/v2";
            string Url = BaseUrl + "/send";

            var Value = new SendSmsRequest() { senders = new[] { "300000135" }, recipients = new[] { phoneNumber }, messages = new[] { message } };
            var Authorization = new Dictionary<string, string>() { { "Username", "tazir_org/magfa" }, { "Password", "BIeJIGKBzNvMHAa4" } };

            var Result = (await Url.CallApi(Value, AnuResult.HttpError_Send_Sms, authorization: Authorization)).JsonDeserialize<SendSmsResponse>();

            if (Result.status != 0)
            {
                throw new AnuExceptions(AnuResult.Error_Send_Sms);
            }

        }

    }
}
