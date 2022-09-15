namespace Anu.PunishmentOrg.DataModel
{
    public class Statistic
    {
        [System.ComponentModel.DataAnnotations.Required]
        public long? CountTotal { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long? CountUnSeen { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public long? CountSeen { get; set; }
    }
}
