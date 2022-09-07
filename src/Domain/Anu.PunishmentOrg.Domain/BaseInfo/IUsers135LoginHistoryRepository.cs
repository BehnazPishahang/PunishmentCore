using Anu.PunishmentOrg.DataModel.BaseInfo;

namespace Anu.PunishmentOrg.Domain.BaseInfo
{
    public interface IUsers135LoginHistoryRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.Users135LoginHistory>
    {

        public Task<Users135LoginHistory> LastRecordHistoryPerDay(string userID, string date);

        public Task<Users135LoginHistory> LastRecordHistory(string userID);

    }
}
