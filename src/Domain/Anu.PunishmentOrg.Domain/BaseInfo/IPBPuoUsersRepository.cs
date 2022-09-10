
namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBPuoUsersRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PBPuoUsers>
{

    public Task<DataModel.BaseInfo.PBPuoUsers> GetByIdtest(string id);

    public void UpdateParent(DataModel.BaseInfo.PBPuoUsers pBPuoUsers );
}