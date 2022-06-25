using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg
{
    public class PCaseRepository : GenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>, Domain.Interface.PunishmentOrg.Case.IPCaseRepository
    {
        public PCaseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>> GetPCaseByNo(string no)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase>().Where(a=>a.No==no).ToListAsync();
        }
    }
}
