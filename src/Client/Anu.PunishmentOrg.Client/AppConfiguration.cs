﻿namespace Anu.PunishmentOrg.Client
{
    public class AppConfiguration
    {
        public const string ConfigurationPosition = "BackendSetting";
        
        public string BackendServerAddress { get; set; }
        public string InqueryPNoticeList { get; set; }
        public string ExportPNotice { get; set; }
        public string RegisterAddress { get; set; }
        public string LoginAddress { get; set; }
        public string SecondStepLogin { get; set; }
        public string ChangePNoticeViewByUserStatus { get; set; }
        public string GetCountOfUnSeenPNoticeByUser { get; set; }
        public string GetGeoLocationList { get; set; }
        public string RecieveGravamen { set; get; }
        public static AppConfiguration Instance { get; set; }
    }
}