using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace Anu.BaseInfo.DataAccess.FrontEndSecurity
{
    public class GFESUserAccessRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.FrontEndSecurity.GFESUserAccess>,
        Domain.FrontEndSecurity.IGFESUserAccessRepository
    {
        public GFESUserAccessRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType)
        {
            var gfeUser = await _context.Set<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>()
                .Include(a => a.TheGFESUser)
                .Include(a => a.TheGFESUserAccessType)
                .Where(a =>
                    a.TheGFESUser.UserID == userName.Trim() 
                    && a.TheGFESUser.Password == hashedPassword 
                    //&& a.TheGFESUserAccessType.Id == GFESUserAccessType
                    ).ToListAsync();

            return gfeUser.Where(a =>
                    a.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                    a.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.SahmsiDateNow() &&
                    a.ToDateTime.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                    a.FromDateTime.ToDateTime() <= CalendarHelper.SahmsiDateNow());
        }
    }
}
