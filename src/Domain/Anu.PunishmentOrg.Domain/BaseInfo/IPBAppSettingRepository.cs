
namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBAppSettingRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.BaseInfo.PBAppSetting>
{
    public Task<Anu.PunishmentOrg.DataModel.BaseInfo.PBAppSetting> GetAppSettingByKey(string key);

}