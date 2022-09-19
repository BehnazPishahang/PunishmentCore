namespace Anu.PunishmentOrg.Client
{
    public class AppConfiguration
    {
        public const string ConfigurationPosition = "BackendSetting";
        
        public string BackendServerAddress { get; set; }
        public string InqueryPNoticeList { get; set; }
        public string ExportPNotice { get; set; }

        public string   SendSmsAuth{ get; set; }
        public string RegisterAddress{ get; set; }
        public string  LoginAddress { get; set; }
        public string ChangePhoneNumber { get; set; }
        public string GetProfile { get; set; }
        public string ChangePNoticeViewByUserStatus { get; set; }
        public string GetCountOfUnSeenPNoticeByUser { get; set; }
        public string GetGeoLocationList { get; set; }
        public string RecieveGravamen { set; get; }
        public static AppConfiguration Instance { get; set; }
        public string GetGravamenByFollowingNo { set; get; }

        public string GetGravamenListByNationalNo { set; get; }

        public string SendSmsForChangePhoneNumber { get; set; }
        public string ChangePhoneNumberV2 { get; set; }
    }
}