
namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBPuoUsersRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PBPuoUsers>
{
    public Task<DataModel.BaseInfo.PBPuoUsers> GetGFESUserByUserNameAndPassWordAsyncWithAccessTypes(string userName, string passWord);
    public Task<DataModel.BaseInfo.PBPuoUsers> GetGFESUserByUserNameAndPassWordAsync(string userName, string passWord);
    public void UpdateParent(DataModel.BaseInfo.PBPuoUsers pBPuoUsers );
}