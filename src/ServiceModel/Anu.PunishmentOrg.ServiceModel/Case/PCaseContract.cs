namespace Anu.PunishmentOrg.ServiceModel.Case
{
    [System.ComponentModel.DisplayName("پرونده در سرویس")]
    public class PCaseContract
    {
        public PCaseContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

    }
}
