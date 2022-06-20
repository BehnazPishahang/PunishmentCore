using Anu.BaseInfo.FrontEndSecurity;
using Microsoft.EntityFrameworkCore;
using Utility.DateTimeUtility;

namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public class GFESUserAccessRepository : GenericRepository<GFESUserAccess>, Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository
    {
        public GFESUserAccessRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType)
        {

            return await _context.Set<GFESUserAccess>()
                .Include(a => a.TheGFESUser)
                .Include(a => a.TheGFESUserAccessType)
                .Where(a =>
                    a.TheGFESUser.UserID == userName.Trim() &&
                    a.TheGFESUser.Password == hashedPassword &&
                    a.TheGFESUser.EndDate.toDateTime() >= DateTimeUtility.DateTimeNow() &&
                    a.TheGFESUser.StartDate.toDateTime() <= DateTimeUtility.DateTimeNow() &&
                    a.ToDateTime.toDateTime() >= DateTimeUtility.DateTimeNow() &&
                    a.FromDateTime.toDateTime() <= DateTimeUtility.DateTimeNow() &&
                    a.TheGFESUserAccessType.Id == GFESUserAccessType
                    ).ToListAsync();
        }
    }
}
