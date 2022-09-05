using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.Utility.Linq;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo
{
    public class Users135LoginHistoryRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.BaseInfo.Users135LoginHistory>, Domain.BaseInfo.IUsers135LoginHistoryRepository
    {
        public Users135LoginHistoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Users135LoginHistory> LastRecordHistory(string userID)
        {
            return await _context.Set<Users135LoginHistory>().Where(a => a.ThePunishmentOrg135Users.Id == userID)
                .AnuOrderBy(a => a.SendCodePerDay, false).Take(1).SingleOrDefaultAsync();
        }

        public async Task<Users135LoginHistory> LastRecordHistoryPerDay(string userID, string date)
        {
            var query = @"SELECT * from
            (SELECT * FROM USERS135LOGINHISTORY UL
            WHERE UL.PUNISHMENTORG135USERSID = '" + userID + @"' AND TO_DATE(SUBSTR(UL.SENDCODEDATETIME, 1, 10), 'YYYY/MM/DD') = TO_DATE('" + date + @"', 'YYYY/MM/DD')
            ORDER BY UL.SENDCODEDATETIME DESC)
            WHERE ROWNUM = 1";

            return await _context.Set<Users135LoginHistory>().FromSqlRaw(query).SingleOrDefaultAsync();

        }
    }
}
