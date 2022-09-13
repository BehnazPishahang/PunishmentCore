using Anu.Commons.ServiceModel.ServicePaging;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.PGravamen;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.PGravamen;

//! کل من علیها fun
public class PGravamenRepository : GenericRepository<DataModel.Gravamen.PGravamen>, IPGravamenRepository
{
    public PGravamenRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {

    }

    public async Task<DataModel.Gravamen.PGravamen> GetPGravamenByFollowUpNo(string followUpNo)
    {
        return await _context.Set<DataModel.Gravamen.PGravamen>()
                             .Where(a => a.FollowUpNo == followUpNo &&
                                         a.GravamenOrReport == Enumerations.GravamenOrReport.Gravamen)
                             .Include(a => a.TheObjectState)
                             .Include(a => a.TheReceiveUnit)
                             .Include(a => a.ThePGravamenRejectOrDefectRSList)
                             .ThenInclude(a => a.ThePBGravamenRejectDefectType)
                             .FirstOrDefaultAsync();
    }
}


