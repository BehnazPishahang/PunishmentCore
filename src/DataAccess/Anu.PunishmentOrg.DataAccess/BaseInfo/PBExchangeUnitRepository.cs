using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Microsoft.EntityFrameworkCore;
using Utility.Guard;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo;

public class PBExchangeUnitRepository : GenericRepository<DataModel.BaseInfo.PBExchangeUnit>, IPBExchangeUnitRepository
{
    public PBExchangeUnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<PBExchangeUnit>> GetByCode(string code)
    {
        var najaUnitId = await _context.Set<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit>().Where(x => x.Code == code).Select(n => n.Id).FirstAsync();

        najaUnitId.Null(AnuResult.Error);

        var pbExchange = await _context.Set<PBExchangeUnit>().Where(p => p.Id == najaUnitId.ToString()).ToListAsync();

        return pbExchange;
    }
}


