using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.ExchangeData
{
    public class NAJAUnitRepository: GenericRepository<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit>, INAJAUnitRepository
    {
        public NAJAUnitRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<NAJAUnit> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit>().Where(x => x.Code == code).FirstOrDefaultAsync();


        }
    }
}
