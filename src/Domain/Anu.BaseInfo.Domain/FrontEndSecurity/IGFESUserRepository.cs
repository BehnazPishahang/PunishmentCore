namespace Anu.BaseInfo.Domain.FrontEndSecurity
{
    public interface IGFESUserRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>
    {
        public Task<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord);
        public Task<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord);
    }
}
