using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Anu.Utility.Linq;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo
{
    public class PBPuoUsersHistoryRepository : GenericRepository<PBPuoUsersHistory>, IPBPuoUsersHistoryRepository
    {
        public PBPuoUsersHistoryRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<PBPuoUsersHistory> LastRecordHistory(string userID)
        {
            return await _context.Set<PBPuoUsersHistory>().Where(a => a.ThePBPuoUsers.Id == userID)
                .AnuOrderBy(a => a.CountCodePerDay, false).Take(1).SingleOrDefaultAsync();
        }

        public async Task<PBPuoUsersHistory> LastRecordHistoryPerDay(string userID, string date)
        {
            var query = @"SELECT * from
            (SELECT * FROM PBPuoUsersHistory UL
            WHERE UL.PBPUOUSERSID = '" + userID + @"' AND TO_DATE(SUBSTR(UL.SENDCODEDATETIME, 1, 10), 'YYYY/MM/DD') = TO_DATE('" + date + @"', 'YYYY/MM/DD')
            ORDER BY UL.SENDCODEDATETIME DESC)
            WHERE ROWNUM = 1";

            return await _context.Set<PBPuoUsersHistory>().FromSqlRaw(query).SingleOrDefaultAsync();
        }
    }
}
