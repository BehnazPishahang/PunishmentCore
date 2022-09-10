using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.DataAccess.BaseInfo;

public class PBProductCurrencyTypeRepository : GenericRepository<DataModel.BaseInfo.PBProductCurrencyType>, IPBProductCurrencyTypeRepository
{
    public PBProductCurrencyTypeRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {
    }

    public async Task<PBProductCurrencyType> GetByCode(string code)
    {
        return await _context.Set<PBProductCurrencyType>().Where(x => x.Code == code).FirstOrDefaultAsync();
    }

    public async Task<string> GetMaxLevelCode(string levelcode)
    {
        return _context.Set<PBProductCurrencyType>().Where(x => x.LevelCode.StartsWith(levelcode)).Select(x => x.LevelCode).Max();
    }
}
