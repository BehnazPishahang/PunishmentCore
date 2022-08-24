
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility.Sms.ServiceModel;
using Utility.Exceptions;

namespace Anu.Utility.Sms
{
    public static class SmsSender
    {
        public static async Task SendSms(string phoneNumber,string message)
        {
            string BaseUrl = "https://sms.magfa.com/api/http/sms/v2";
            string Url = BaseUrl + "/send";

            var Value = new SendSmsRequest() { senders = new[] { "300000135" }, recipients = new[] { phoneNumber }, messages = new[] { message } };
            var Authorization = new Dictionary<string, string>() { { "Username", "tazir_org/magfa" }, { "Password", "BIeJIGKBzNvMHAa4" } };

            var Result = (await Url.CallApi<SendSmsRequest>(Value, AnuResult.HttpError_Send_Sms, authorization: Authorization)).JsonDeserialize<SendSmsResponse>();

            if (Result.status != 0)
            {
                throw new AnuExceptions(AnuResult.Error_Send_Sms);
            }

        }

    }
}
