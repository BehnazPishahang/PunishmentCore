namespace Anu.PunishmentOrg.Client
{
    public static class SharedInfo
    {
        public static string NationalCode { get; set; }

        public static string? AccessToken { get; set; }  
         
        public static bool? LoadAllNoticeList { get; set; }

        public static string AccessTokenKeyName =  "AccessToken";
        public static string NationalCodeKeyName = "NationalCode";
        public static string strPublicError = "خطای غیرمنتظره رخ داده است لطفا مجددا اقدام نمایید";

    }


}
