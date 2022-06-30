namespace Anu.PunishmentOrg.Domain.Case
{
    public interface IPRegistaryTimeCaseRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.Case.PRegistaryTimeCase>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PRegistaryTimeCase>> GetPRegistaryTimeCaseByNo(string pCaseNo, Anu.PunishmentOrg.Enumerations.PURegisterTimeType timeType);
    }
}
