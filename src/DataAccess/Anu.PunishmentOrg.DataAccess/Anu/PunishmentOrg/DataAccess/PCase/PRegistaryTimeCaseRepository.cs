using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace Anu.PunishmentOrg.DataAccess.PCase
{
    public class PRegistaryTimeCaseRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Case.PRegistaryTimeCase>, Domain.Case.IPRegistaryTimeCaseRepository
    {
        public PRegistaryTimeCaseRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.Case.PRegistaryTimeCase>> GetPRegistaryTimeCaseByNo(string pCaseNo, Anu.PunishmentOrg.Enumerations.PURegisterTimeType timeType)
        {
            var q=  _context.Set<DataModel.Case.PRegistaryTimeCase>()
                .Include(x => x.ThePCase)
                .Include(x => x.ThePRegistaryTime)
                .Where(a =>
                a.ThePCase.No == pCaseNo &&
                a.ThePRegistaryTime.TimeType == timeType
                ).OrderBy(a => a.ThePRegistaryTime.RegisterDate);

            var script = q.ToQueryString();
            var prt =await  q.ToListAsync();

            return prt.Where(a => a.ThePRegistaryTime.RegisterDate.ToDateTime() >= CalendarHelper.DateTimeNow());
        }
    }
}
