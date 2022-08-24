namespace Anu.Utility.Sms.ServiceModel
{
    public class SendSmsResponse
    {
        public int status { get; set; }
        public MessageContract[] messages { get; set; }
    }
}
