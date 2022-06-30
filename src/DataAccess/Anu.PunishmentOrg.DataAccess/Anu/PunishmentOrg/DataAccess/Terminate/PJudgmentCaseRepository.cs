using Microsoft.EntityFrameworkCore;


namespace Anu.PunishmentOrg.DataAccess.Terminate
{
    public class PJudgmentCaseRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Terminate.PJudgmentCase>, Domain.Terminate.IPJudgmentCaseRepository
    {
        public PJudgmentCaseRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.Terminate.PJudgmentCase>> GetPJudgmentCaseByObjectID(string ObjectID)
        {
            return await _context.Set<DataModel.Terminate.PJudgmentCase>()
                .Include(a=>a.ThePCase)
                .Where(a=>a.ThePCase.SourceObjectId==ObjectID)
                .OrderByDescending(a=>a.ThePJudgment.JudgeDateTime)
                .ToListAsync();
        }
    }
}
