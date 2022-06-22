namespace PunishmentOrg.Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public interface IGFESUserAccessRepository : IGenericRepository<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>
    {
        public Task<IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType);

    }
}
