namespace Anu.Utility.Sms.ServiceModel
{
    public class SendSmsRequest
    {
        public string[] senders { get; set; }
        public string[] messages { get; set; }
        public string[] recipients { get; set; }
    }
}
