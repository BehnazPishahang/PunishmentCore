namespace Anu.Commons.ServiceModel.ServiceStatisticResponse
{
    public class StatisticContract
    {
        public StatisticContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        public long? CountTotal { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long? CountUnSeen { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long? CountSeen { get; set; }
    }
}
