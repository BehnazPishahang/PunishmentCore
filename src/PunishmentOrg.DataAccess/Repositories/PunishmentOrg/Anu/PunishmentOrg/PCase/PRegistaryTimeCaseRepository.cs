using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.PCase
{
    public class PRegistaryTimeCaseRepository : GenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PRegistaryTimeCase>, Domain.Interface.PunishmentOrg.DataModelPunishmentOrgAnu.PunishmentOrg.Case.IPRegistaryTimeCaseRepository
    {
        public PRegistaryTimeCaseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PRegistaryTimeCase>> GetPCaseByNo(string pCaseNo, DataModel.Anu.Enumerations.PunishmentOrg.PURegisterTimeType timeType)
        {
            return await _context.Set<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PRegistaryTimeCase>()
                .Include(x => x.ThePCase)
                .Include(x=>x.ThePRegistaryTime)
                .Where(a =>
                a.ThePCase.No == pCaseNo &&
                a.ThePRegistaryTime.RegisterDate.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                a.ThePRegistaryTime.TimeType == timeType
                ).ToListAsync();
        }
    }
}
