using Anu.Utility.Extensions;
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
            var now = DateTime.Now.ToPersianDateTime();

            return gfeUser.Where(a =>
                    a.TheGFESUser.EndDate.CompareTo(now) > -1 &&
                                            a.TheGFESUser.StartDate.CompareTo(now) < 1 &&
                                            a.ToDateTime.CompareTo(now) > -1 &&
                                            a.FromDateTime.CompareTo(now) < 1);
        }
    }
}
