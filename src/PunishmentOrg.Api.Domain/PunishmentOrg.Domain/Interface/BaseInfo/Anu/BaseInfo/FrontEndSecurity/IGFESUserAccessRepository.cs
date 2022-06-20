using Anu.BaseInfo.FrontEndSecurity;

namespace PunishmentOrg.Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public interface IGFESUserAccessRepository : IGenericRepository<GFESUserAccess>
    {
        public Task<IEnumerable<GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType);

    }
}
