
namespace Anu.PunishmentOrg.Domain.BaseInfo;

public interface IPBCountyLocatedUnitRepository : Anu.Domain.IGenericRepository<Anu.PunishmentOrg.DataModel.BaseInfo.PBCountyLocatedUnit>
{
    public Task<Anu.PunishmentOrg.DataModel.BaseInfo.PBCountyLocatedUnit> GetRelatedPBCountyLocatedUnitToGeolocationWithLocationCode(string code);

}