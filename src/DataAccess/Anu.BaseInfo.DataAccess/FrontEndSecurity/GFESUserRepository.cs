namespace Anu.BaseInfo.DataAccess.FrontEndSecurity
{
    public class GFESUserRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.BaseInfo.DataModel.FrontEndSecurity.GFESUser>, Anu.BaseInfo.Domain.FrontEndSecurity.IGFESUserRepository
    {
        public GFESUserRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }
    }
}
