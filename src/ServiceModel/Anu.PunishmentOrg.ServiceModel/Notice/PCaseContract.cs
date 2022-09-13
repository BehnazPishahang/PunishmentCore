namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    public class PCaseContract
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره پرونده")]
        public string? No { get; set; }
    }
}