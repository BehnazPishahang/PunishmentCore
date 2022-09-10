using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo
{
    public class PunishmentOrg135UsersRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.BaseInfo.PunishmentOrg135Users>, Domain.BaseInfo.IPunishmentOrg135UsersRepository
    {
        public PunishmentOrg135UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<int> DeleteUser(string id)
        {
            var query1 = @"DELETE FROM USERS135LOGINHISTORY WHERE PUNISHMENTORG135USERSID='"+id+"'";
            var query2 = @"DELETE FROM PUNISHMENTORG135USERS WHERE ID='" + id + @"'";
            var query3 = @"DELETE FROM GFESUSER WHERE ID='" + id + @"'";

            var run1 = await _context.Database.ExecuteSqlRawAsync(query1);
            if (run1<0)
            {
                return run1;
            }
            var run2 = await _context.Database.ExecuteSqlRawAsync(query2);
            if (run2 < 0)
            {
                return run2;
            }
            return await _context.Database.ExecuteSqlRawAsync(query3);
        }

        public async Task<PunishmentOrg135Users> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord)
        {
            string passWordHash = MD5Core.GetHashString(passWord);

            var punishmentOrg135Users = await _context.Set<PunishmentOrg135Users>()
                                      .Where(user =>
                                             user.UserID == userName.Trim()
                                           )
                                      .Select(user => user)
                                      .SingleOrDefaultAsync();

            if (punishmentOrg135Users == null) return null;

            if (punishmentOrg135Users.DynomicPassword != passWordHash)
            {
                return null;
            }

            return punishmentOrg135Users;
        }

        public async Task<PunishmentOrg135Users> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord)
        {
            string passWordHash = MD5Core.GetHashString(passWord);

            var punishmentOrg135Users = await _context.Set<PunishmentOrg135Users>()
                                      .Include(user => user.TheGFESUserAccessList)
                                      .ThenInclude(userAccess => userAccess.TheGFESUserAccessType)
                                      .Where(user =>
                                             user.UserID == userName.Trim()
                                           )
                                      .Select(user => user)
                                      .SingleOrDefaultAsync();

            if (punishmentOrg135Users == null) return null;

            if (punishmentOrg135Users.DynomicPassword != passWordHash)
            {
                return null;
            }

            if (punishmentOrg135Users.TheGFESUserAccessList != null && punishmentOrg135Users.TheGFESUserAccessList.Count() > 0)
            {
                var theGFESUser = punishmentOrg135Users.TheGFESUserAccessList
                                         .Where(userAccess =>
                                                userAccess.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                                                userAccess.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.SahmsiDateNow() &&
                                                userAccess.ToDateTime.ToDateTime() >= CalendarHelper.SahmsiDateNow() &&
                                                userAccess.FromDateTime.ToDateTime() <= CalendarHelper.SahmsiDateNow())
                                         .Select(s => s.TheGFESUser)
                                         .FirstOrDefault();

                return await _context.Set<PunishmentOrg135Users>()
                                      .Where(user =>
                                             user.Id == theGFESUser.Id
                                           )
                                      .SingleOrDefaultAsync();
            }


            return punishmentOrg135Users;
        }

        public async Task<int> UpdateDynamicPassword(string id, string password)
        {
            var query = @"UPDATE PUNISHMENTORG135USERS
                          SET DYNOMICPASSWORD = '"+password+@"'
                          WHERE ID = '"+id+@"';";

            return await _context.Database.ExecuteSqlRawAsync(query);
        }

        public async Task<int> UpdatePhoneNumber(string id, string phoneNumber)
        {
            var query = @"UPDATE GFESUSER
                          SET MOBILENUMBER4SMS = '" + phoneNumber + @"'
                          WHERE ID = '" + id + @"';";

            return await _context.Database.ExecuteSqlRawAsync(query);
        }
    }
}
