using Anu.PunishmentOrg.Case;
using Anu.PunishmentOrg.DiscoveryMinutes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg
{
    public class PCaseRepository : GenericRepository<PCase>, Domain.Interface.PunishmentOrg.IPCaseRepository
    {
        public PCaseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PCase> GetTerminateCaseByNo(string no)
        {
            return await _context.Set<PCase>().FirstOrDefaultAsync(x => x.No == no);
        }
    }
}
