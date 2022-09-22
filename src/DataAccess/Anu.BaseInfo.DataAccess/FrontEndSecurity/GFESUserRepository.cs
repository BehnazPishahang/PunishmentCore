using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.Utility.Extensions;
using Microsoft.EntityFrameworkCore;

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

            if (theGFESUser.TheGFESUserAccessList != null && theGFESUser.TheGFESUserAccessList.Count() > 0)
            {
                var now = DateTime.Now.ToPersianDateTime();

                return theGFESUser.TheGFESUserAccessList
                                         .Where(userAccess =>
                                                 userAccess.TheGFESUser.EndDate.CompareTo(now) > -1 &&
                                            userAccess.TheGFESUser.StartDate.CompareTo(now) < 1 &&
                                            userAccess.ToDateTime.CompareTo(now) > -1 &&
                                            userAccess.FromDateTime.CompareTo(now) < 1)
                                         .Select(s => s.TheGFESUser)
                                         .FirstOrDefault();
            }


            return theGFESUser;
        }
    }
}
