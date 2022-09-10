using Anu.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.Types
{
    public class MeasurementUnitTypeRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Types.MeasurementUnitType>, Anu.BaseInfo.Domain.Types.IMeasurementUnitTypeRepository
    {
        public MeasurementUnitTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Anu.BaseInfo.DataModel.Types.MeasurementUnitType> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.Types.MeasurementUnitType>().Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
