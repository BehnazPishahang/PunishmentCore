namespace Anu.PunishmentOrg.Domain.BaseInfo
{
    public interface IPunishmentOrg135UsersRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PunishmentOrg135Users>
    {
        public Task<DataModel.BaseInfo.PunishmentOrg135Users> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord);
        public Task<DataModel.BaseInfo.PunishmentOrg135Users> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord);
        public Task<int> UpdateDynamicPassword(string id, string password);
        public Task<int> UpdatePhoneNumber(string id, string phoneNumber);

        public Task<int> DeleteUser(string id);
    }
}
