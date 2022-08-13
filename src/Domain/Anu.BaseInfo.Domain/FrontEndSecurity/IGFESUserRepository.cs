namespace Anu.BaseInfo.Domain.FrontEndSecurity
{
    public interface IGFESUserRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>
    {
        public Task<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord);
    }
}
