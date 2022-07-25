namespace Anu.PunishmentOrg.Domain.Terminate
{
    public interface IPJudgmentCaseRepository: Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentCase>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.Terminate.PJudgmentCase>> GetPJudgmentCaseByObjectID(string ObjectID);

    }
}
