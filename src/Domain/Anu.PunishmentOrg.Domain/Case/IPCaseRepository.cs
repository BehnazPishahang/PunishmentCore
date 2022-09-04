namespace Anu.PunishmentOrg.Domain.Case
{
    public interface IPCaseRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.Case.PCase>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PCase>> GetPCaseByNo(string no);
        public Task<Anu.PunishmentOrg.DataModel.Case.PCase> GetOnePCaseByNo(string no);
        
    }
}
