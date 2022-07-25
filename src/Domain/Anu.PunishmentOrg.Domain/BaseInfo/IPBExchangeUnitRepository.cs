
namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBExchangeUnitRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PBExchangeUnit>
{
    public Task<IEnumerable<DataModel.BaseInfo.PBExchangeUnit>> GetByCode(string code);

}