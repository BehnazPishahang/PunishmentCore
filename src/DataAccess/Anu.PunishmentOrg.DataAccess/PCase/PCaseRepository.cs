using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.PCase
{
    public class PCaseRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.PunishmentOrg.DataModel.Case.PCase>, Domain.Case.IPCaseRepository
    {
        public PCaseRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PCase>> GetPCaseByNo(string no)
        {
            return await _context.Set<Anu.PunishmentOrg.DataModel.Case.PCase>()
                .Include(x => x.TheHandlerUnit)
                .ThenInclude(x=>x.TheGUnitType)
                .Where(a=>a.No==no)
                .ToListAsync();
        }
    }
}
