using Microsoft.EntityFrameworkCore;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
//using Utility.CalendarHelper;
using Anu.Utility.Extensions;

namespace Anu.PunishmentOrg.Domain.BaseInfo;

public class PBPuoUsersRepository : GenericRepository<DataModel.BaseInfo.PBPuoUsers>, IPBPuoUsersRepository
{
    public PBPuoUsersRepository(ApplicationDbContext context) : base(context)
    {
    }
    public async Task<PBPuoUsers> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord)
    {
        string passWordHash = MD5Core.GetHashString(passWord);

        var pBPuoUsers = await _context.Set<PBPuoUsers>()
                                  .Where(user =>
                                         user.UserID == userName.Trim()
                                       )
                                  .Select(user => user)
                                  .SingleOrDefaultAsync();

        if (pBPuoUsers == null) return null;

        if (pBPuoUsers.DynomicPassword != passWordHash)
        {
            return null;
        }

        return pBPuoUsers;
    }

    public async Task<PBPuoUsers> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord)
    {
        string passWordHash = MD5Core.GetHashString(passWord);

        var pBPuoUsers = await _context.Set<PBPuoUsers>()
                                  .Include(user => user.TheGFESUserAccessList)
                                  .ThenInclude(userAccess => userAccess.TheGFESUserAccessType)
                                  .Where(user =>
                                         user.UserID == userName.Trim()
                                       )
                                  .Select(user => user)
                                  .SingleOrDefaultAsync();

        if (pBPuoUsers == null) return null;

        if (pBPuoUsers.DynomicPassword != passWordHash)
        {
            return null;
        }

        if (pBPuoUsers.TheGFESUserAccessList != null && pBPuoUsers.TheGFESUserAccessList.Count() > 0)
        {
            var now = DateTime.Now.ToPersianDateTime();
            var theGFESUserAccessList = pBPuoUsers.TheGFESUserAccessList
                                     .Where(userAccess =>
                                            userAccess.TheGFESUser.EndDate.CompareTo(now) > -1 &&
                                            userAccess.TheGFESUser.StartDate.CompareTo(now) < 1 &&
                                            userAccess.ToDateTime.CompareTo(now) > -1 &&
                                            userAccess.FromDateTime.CompareTo(now) < 1)
                                     .FirstOrDefault();

            return await _context.Set<PBPuoUsers>()
                                  .Where(user =>
                                         user.Id == theGFESUserAccessList.TheGFESUser.Id
                                       )
                                  .SingleOrDefaultAsync();
        }


        return pBPuoUsers;
    }

    public async void UpdateParent(PBPuoUsers pBPuoUsers)
    {
        _context.Update<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>(pBPuoUsers);
    }
}