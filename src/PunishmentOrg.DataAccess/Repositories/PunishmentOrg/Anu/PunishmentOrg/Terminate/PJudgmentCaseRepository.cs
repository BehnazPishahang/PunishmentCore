using Microsoft.EntityFrameworkCore;


namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.Terminate
{
    public class PJudgmentCaseRepository : GenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate.PJudgmentCase>, Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.Terminate.IPJudgmentCaseRepository
    {
        public PJudgmentCaseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate.PJudgmentCase>> GetPJudgmentCaseByObjectID(string ObjectID)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.Terminate.PJudgmentCase>()
                .Include(a=>a.ThePCase)
                .Where(a=>a.ThePCase.SourceObjectId==ObjectID)
                .OrderByDescending(a=>a.ThePJudgment.JudgeDateTime)
                .ToListAsync();
        }
    }
}
