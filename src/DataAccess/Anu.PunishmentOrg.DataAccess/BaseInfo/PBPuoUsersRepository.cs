using Microsoft.EntityFrameworkCore;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;

namespace Anu.PunishmentOrg.Domain.BaseInfo;

public class PBPuoUsersRepository : GenericRepository<DataModel.BaseInfo.PBPuoUsers>, IPBPuoUsersRepository
{
    public PBPuoUsersRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<PBPuoUsers> GetByIdtest(string id)
    {
        return await _context.Set<PBPuoUsers>().Where(a => a.Id == id).FirstOrDefaultAsync();
    }

    public async void  UpdateParent(PBPuoUsers pBPuoUsers)
    {
        _context.Update<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>(pBPuoUsers);
    }
}