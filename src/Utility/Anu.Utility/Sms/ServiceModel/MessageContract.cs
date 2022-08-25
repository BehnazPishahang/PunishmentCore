namespace Anu.Utility.Sms.ServiceModel
{
    public class MessageContract
    {
        public int status { get; set; }
        public long id { get; set; }
        public int userId { get; set; }
        public int parts { get; set; }
        public float tariff { get; set; }
        public string alphabet { get; set; }
        public string recipient { get; set; }
    }
}
