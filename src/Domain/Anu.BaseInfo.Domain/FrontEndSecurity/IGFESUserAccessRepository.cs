namespace Anu.BaseInfo.Domain.FrontEndSecurity
{
    public interface IGFESUserAccessRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>
    {
        public Task<IEnumerable<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType);

    }
}
