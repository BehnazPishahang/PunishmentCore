namespace PunishmentOrg.Domain.Interface.PunishmentOrg
{
    public interface IPCaseRepository : IGenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>
    {
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>> GetPCaseByNo(string no);
    }
}
