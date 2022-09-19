using Anu.PunishmentOrg.Enumerations;

namespace Anu.PunishmentOrg.Domain.Case
{
    public interface IPCaseRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.Case.PCase>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PCase>> GetPCaseByNo(string no);
        public Task<Anu.PunishmentOrg.DataModel.Case.PCase> GetOnePCaseByNo(string no);
        public Task<Anu.PunishmentOrg.DataModel.Statistic> GetStatistic(string nationalCode);
        public Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PCase>> GetAllPCaseWithNationalCode(string nationalCode, PUCaseArchiveState caseArchiveState = PUCaseArchiveState.None);
        public Task<IEnumerable<IEnumerable<string>>> ExportInqueryPCase(string nationalCode, string no);


    }
}
