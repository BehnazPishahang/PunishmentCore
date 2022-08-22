using Anu.SmsMagfa.Utility.Sms;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class SmsAuthentication
    {
        public static async Task<string> SendAuthenticateSms(this string phoneNumber,int CountCharacter)
        {
            string code = Anu.Utility.Utility.GetRandomNumber(CountCharacter);
            string message = "کد فعال سازی شما {0} است .";
            message = string.Format(message,code);

            await SmsSender.SendSms(message);

            return code;
        }
    }
}
