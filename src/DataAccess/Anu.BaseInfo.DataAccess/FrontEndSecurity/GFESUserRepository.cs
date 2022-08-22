using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace Anu.BaseInfo.DataAccess.FrontEndSecurity
{
    public class GFESUserRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>, Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository
    {
        public GFESUserRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<GFESUser> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord)
        {
            string passWordHash = MD5Core.GetHashString(passWord);

            var theGFESUser = await _context.Set<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>()
                                      .Where(user =>
                                             user.UserID == userName.Trim()
                                           )
                                      .Select(user => user)
                                      .SingleOrDefaultAsync();

            if (theGFESUser == null) return null;

            if (theGFESUser.Password != passWordHash)
            {
                return null;
            }

            return theGFESUser;
        }

        public async Task<GFESUser> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord)
        {
            string passWordHash = MD5Core.GetHashString(passWord);

            var theGFESUser = await _context.Set<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>()
                                      .Include(user => user.TheGFESUserAccessList)
                                      .ThenInclude(userAccess => userAccess.TheGFESUserAccessType)
                                      .Where(user =>
                                             user.UserID == userName.Trim()
                                           )
                                      .Select(user => user)
                                      .SingleOrDefaultAsync();

            if (theGFESUser == null) return null;

            if (theGFESUser.Password != passWordHash)
            {
                return null;
            }

            if (theGFESUser.TheGFESUserAccessList != null && theGFESUser.TheGFESUserAccessList.Count()>0)
            {
                return theGFESUser.TheGFESUserAccessList
                                         .Where(userAccess =>
                                                userAccess.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                                                userAccess.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.DateTimeNow() &&
                                                userAccess.ToDateTime.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                                                userAccess.FromDateTime.ToDateTime() <= CalendarHelper.DateTimeNow())
                                         .Select(s => s.TheGFESUser)
                                         .FirstOrDefault();
            }


            return theGFESUser;
        }

        public async Task<GFESUser> GetGFESUserByPhoneNumberAndPassWordAsyncWithAccessTypes(string phoneNumber, string passWord)
        {
            string passWordHash = MD5Core.GetHashString(passWord);

            var theGFESUser = await _context.Set<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>()
                                      .Include(user => user.TheGFESUserAccessList)
                                      .ThenInclude(userAccess => userAccess.TheGFESUserAccessType)
                                      .Where(user =>
                                             user.MobileNumber4SMS == phoneNumber.Trim()
                                           )
                                      .Select(user => user)
                                      .SingleOrDefaultAsync();

            if (theGFESUser == null) return null;

            if (theGFESUser.Password != passWordHash)
            {
                return null;
            }

            if (theGFESUser.TheGFESUserAccessList != null && theGFESUser.TheGFESUserAccessList.Count() > 0)
            {
                return theGFESUser.TheGFESUserAccessList
                                         .Where(userAccess =>
                                                userAccess.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                                                userAccess.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.DateTimeNow() &&
                                                userAccess.ToDateTime.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                                                userAccess.FromDateTime.ToDateTime() <= CalendarHelper.DateTimeNow())
                                         .Select(s => s.TheGFESUser)
                                         .FirstOrDefault();
            }


            return theGFESUser;
        }
    }
}
