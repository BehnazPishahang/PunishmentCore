namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public class GFESUserRepository : GenericRepository<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUser>, Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository
    {
        public GFESUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
