using Microsoft.EntityFrameworkCore;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Utility.CalendarHelper;

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
            var theGFESUser = pBPuoUsers.TheGFESUserAccessList
                                     .Where(userAccess =>
                                            userAccess.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                                            userAccess.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.SahmsiDateNow() &&
                                            userAccess.ToDateTime.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                                            userAccess.FromDateTime.ToDateTime() <= CalendarHelper.SahmsiDateNow())
                                     .Select(s => s.TheGFESUser)
                                     .FirstOrDefault();

            return await _context.Set<PBPuoUsers>()
                                  .Where(user =>
                                         user.Id == theGFESUser.Id
                                       )
                                  .SingleOrDefaultAsync();
        }


        return pBPuoUsers;
    }

    public async void  UpdateParent(PBPuoUsers pBPuoUsers)
    {
        _context.Update<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>(pBPuoUsers);
    }
}