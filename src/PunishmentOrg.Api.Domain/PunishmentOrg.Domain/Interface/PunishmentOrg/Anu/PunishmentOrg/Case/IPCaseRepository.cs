namespace PunishmentOrg.Domain.Interface.PunishmentOrg.Case
{
    public interface IPCaseRepository : IGenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>
    {
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>> GetPCaseByNo(string no);
    }
}
