using Anu.Utility.Sms;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class SmsAuthentication
    {
        public static async Task<string> SendAuthenticateSms(this string phoneNumber, int CountCharacter)
        {
            string code = Anu.Utility.Utility.GetRandomNumber(CountCharacter);
            string message = @"Code: {0} " + Environment.NewLine + @" کد ورود شما به پیشخوان تعزیرات";
            message = string.Format(message, code);

            if (!Anu.Utility.Utility.IsDevelopment())
            {
                await SmsSender.SendSms(phoneNumber, message);
            }
            Console.WriteLine(message);

            return code;
        }
    }
}
