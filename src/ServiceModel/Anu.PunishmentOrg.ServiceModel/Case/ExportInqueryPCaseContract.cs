namespace Anu.PunishmentOrg.ServiceModel.Case
{
    public class ExportInqueryPCaseContract
    {
        public ExportInqueryPCaseContract()
        {
        }
        public string? No { get; set; }
        public List<List<string>> Cases { get; set; }
    }
}
