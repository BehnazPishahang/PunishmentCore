
using Anu.PunishmentOrg.DataModel.BaseInfo;

namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBPuoUsersHistoryRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PBPuoUsersHistory>
{

    public Task<PBPuoUsersHistory> LastRecordHistoryPerDay(string userID, string date);

    public Task<PBPuoUsersHistory> LastRecordHistory(string userID);

}